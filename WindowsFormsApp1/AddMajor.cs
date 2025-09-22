using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace WindowsFormsApp1
{
    public partial class AddMajor : Form
    {
        private Dictionary<string, int> facultyIdMap;

        public AddMajor()
        {
            InitializeComponent();
            LoadFacultiesIntoComboBox();
        }
        private void LoadFacultiesIntoComboBox()
        {

    
             string sql = "SELECT faculty_id, faculty_name FROM Faculties ORDER BY faculty_name";
                facultyIdMap = new Dictionary<string, int>();

                using (SqlConnection conn = new SqlConnection(DBconnection.conn))
                {
                conn.Open();
                using (SqlDataReader reader = new SqlCommand(sql, conn).ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["faculty_name"].ToString();
                            int id = Convert.ToInt32(reader["faculty_id"]);
                            facultyIdMap[name] = id;
                            combofaculty.Items.Add(name); // ← Uses your ComboBox
                        }
                    }
                }

            combofaculty.SelectedIndex = -1;
        }

          
                

    private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtmajor.Text)) // ← Uses your TextBox
            {
                MessageBox.Show("Please enter a major name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combofaculty.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFaculty = combofaculty.SelectedItem.ToString();
            if (!facultyIdMap.TryGetValue(selectedFaculty, out int facultyId))
            {
                MessageBox.Show("Invalid faculty selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    string sql = "INSERT INTO Departments (department_name, faculty_id) VALUES (@Name, @FacultyId)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtmajor.Text.Trim());
                        cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Major added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid in main form
                (this.Owner as FacultyManagement)?.LoadMajors();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xls;*.xlsx|All Files|*.*";
            ofd.Title = "Select Excel File";

            if (ofd.ShowDialog() != DialogResult.OK) return;

            List<string> majors = new List<string>();

            try
            {
                // Read Excel file
                using (var workbook = new XLWorkbook(ofd.FileName))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1); // Skip header

                    foreach (var row in rows)
                    {
                        if (row.Cell(1).IsEmpty()) continue;

                        string name = row.Cell(1).GetValue<string>().Trim();
                        if (!string.IsNullOrWhiteSpace(name))
                        {
                            majors.Add(name);
                        }
                    }
                }

                if (majors.Count == 0)
                {
                    MessageBox.Show("No valid major names found in file.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 👇 COPY YOUR "ADD" BUTTON LOGIC — Validate faculty selection
                if (combofaculty.SelectedItem == null)
                {
                    MessageBox.Show("Please select a faculty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedFaculty = combofaculty.SelectedItem.ToString();

                // 👇 COPY YOUR "ADD" BUTTON LOGIC — Get facultyId from database
                int facultyId = 0;
                string sqlGetId = "SELECT faculty_id FROM Faculties WHERE faculty_name = @Name";
                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlGetId, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", selectedFaculty);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            facultyId = Convert.ToInt32(result);
                        }
                    }
                }

                if (facultyId == 0)
                {
                    MessageBox.Show("Invalid faculty selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 👇 COPY YOUR "ADD" BUTTON LOGIC — Insert majors
                int successCount = 0;
                string sql= "INSERT INTO Departments (department_name, faculty_id) VALUES (@Name, @FacultyId)";

                foreach (string majorName in majors)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                        {
                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@Name", majorName);
                                cmd.Parameters.AddWithValue("@FacultyId", facultyId);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                        successCount++;
                    }
                    catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
                    {
                        // Skip duplicates — same as your ADD button logic
                        continue;
                    }
                }

                MessageBox.Show($"{successCount} majors imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh grid — same as your ADD button
                (this.Owner as FacultyManagement)?.LoadMajors();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Import Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddMajor_Load(object sender, EventArgs e)
        {

        }
    }
    }



