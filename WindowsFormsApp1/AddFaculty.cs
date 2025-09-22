using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddFaculty : Form
    {
       

        public AddFaculty()
        {
            InitializeComponent();
        }

      

        private void btnadd_Click(object sender, EventArgs e)
        {

         
            if (string.IsNullOrWhiteSpace(txtFaculty.Text))
            {
                MessageBox.Show("Please enter a faculty name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string facultyName = txtFaculty.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    string sql = "INSERT INTO Faculties (faculty_name) VALUES (@Name)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", facultyName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Faculty '{facultyName}' added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid
                (this.Owner as FacultyManagement)?.LoadFaculties();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException ex)
            {
                // DEBUG: See what error you're actually getting
                // MessageBox.Show($"Error Number: {ex.Number}\n{ex.Message}");

                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This faculty name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
            ofd.Title = "Select Excel File";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            List<string> importedNames = new List<string>();

            try
            {
                // Read Excel
                using (var workbook = new XLWorkbook(ofd.FileName))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1); // Skip header

                    foreach (var row in rows)
                    {
                        if (row.Cell(1).IsEmpty()) continue;

                        if (row.Cell(1).TryGetValue(out string name))
                        {
                            name = name.Trim();
                            if (!string.IsNullOrWhiteSpace(name))
                            {
                                importedNames.Add(name);
                            }
                        }
                    }

                    if (importedNames.Count == 0)
                    {
                        MessageBox.Show("No valid faculty names found in the file.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Use your DBconnection
                    int successCount = 0;

                    foreach (string name in importedNames)
                    {
                        try
                        {
                            using (SqlConnection conn = new SqlConnection(new DBconnection().conn)) // ← FIXED
                            {
                                string sql = "INSERT INTO Faculties (faculty_name) VALUES (@Name)";
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@Name", name);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    successCount++;
                                }
                            }
                        }
                        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                        {
                            continue; // Skip duplicates
                        }
                    }

                    MessageBox.Show($"{successCount} faculty record(s) imported successfully.", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh grid
                    (this.Owner as FacultyManagement)?.LoadFaculties();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Import failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddFaculty_Load(object sender, EventArgs e)
        {

        }
    }
}
