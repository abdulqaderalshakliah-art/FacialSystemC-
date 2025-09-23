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
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class AddInstructor : Form
    {

        private DBconnection dbHelper;
        private int instructorId;
        private bool isEditMode;
        public AddInstructor()
        {
            InitializeComponent();
            dbHelper = new DBconnection();
            isEditMode = false;
        }

        public AddInstructor(int id) : this()
        {
            instructorId = id;
            isEditMode = true;
        }

        private void LoadFaculties()
        {
            string query = "SELECT faculty_id, faculty_name FROM Faculties ORDER BY faculty_name";
            DataTable dt = dbHelper.ExecuteQuery(query);
            cmbFaculties.DataSource = dt;
            cmbFaculties.DisplayMember = "faculty_name";
            cmbFaculties.ValueMember = "faculty_id";
        }

        private void LoadDepartments(int facultyId)
        {
            string query = "SELECT department_id, department_name FROM Departments WHERE faculty_id = @facultyId ORDER BY department_name";
            var parameters = new[] { new System.Data.SqlClient.SqlParameter("@facultyId", facultyId) };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            cmbDepartments.DataSource = dt;
            cmbDepartments.DisplayMember = "department_name";
            cmbDepartments.ValueMember = "department_id";
        }

        private void LoadInstructorData()
        {
            string query = @"SELECT i.full_name,i.phone ,i.email, d.department_id, d.faculty_id
                           FROM Instructors i
                           INNER JOIN Departments d ON i.department_id = d.department_id
                           WHERE i.instructor_id = @instructorId";

            var parameters = new[] { new System.Data.SqlClient.SqlParameter("@instructorId", instructorId) };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtFirstName.Text = row["first_name"].ToString();
                txtphone.Text = row["phone"].ToString();
                txtEmail.Text = row["email"].ToString();

                // Load faculty and department
                int facultyId = Convert.ToInt32(row["faculty_id"]);
                cmbFaculties.SelectedValue = facultyId;
                LoadDepartments(facultyId);
                cmbDepartments.SelectedValue = Convert.ToInt32(row["department_id"]);
            }
        }

        private void AddInstructor_Load(object sender, EventArgs e)
        {
            LoadFaculties();

            if (isEditMode)
            {
                LoadInstructorData();
            }
        }

        private void cmbFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFaculties.SelectedValue != null)
            {
                int facultyId = Convert.ToInt32(cmbFaculties.SelectedValue);
                LoadDepartments(facultyId);
            }
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("enter instructor name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("enter email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                MessageBox.Show("enter phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtphone.Focus();
                return false;
            }

            if (cmbFaculties.SelectedValue == null)
            {
                MessageBox.Show("enter faculty name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFaculties.Focus();
                return false;
            }

            if (cmbDepartments.SelectedValue == null)
            {
                MessageBox.Show("enter department name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartments.Focus();
                return false;
            }

           

            return true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    string query;
                    System.Data.SqlClient.SqlParameter[] parameters;

                    if (isEditMode)
                    {
                        query = @"UPDATE Instructors SET full_name = @full_name, phone = @phone, 
                                 email = @email, department_id = @departmentId
                                 WHERE instructor_id = @instructorId";

                        parameters = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@full_name", txtFirstName.Text),
                            new System.Data.SqlClient.SqlParameter("@phone", txtphone.Text),
                            new System.Data.SqlClient.SqlParameter("@email", txtEmail.Text),
                            new System.Data.SqlClient.SqlParameter("@departmentId", cmbDepartments.SelectedValue),
                            new System.Data.SqlClient.SqlParameter("@instructorId", instructorId)
                        };
                    }
                    else
                    {
                        query = @"INSERT INTO Instructors (full_name, phone, email, department_id)
                                 VALUES (@full_name, @phone, @email, @departmentId)";

                        parameters = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@full_name", txtFirstName.Text),
                            new System.Data.SqlClient.SqlParameter("@phone", txtphone.Text),
                            new System.Data.SqlClient.SqlParameter("@email", txtEmail.Text),
                            new System.Data.SqlClient.SqlParameter("@departmentId", cmbDepartments.SelectedValue)
                        };
                    }

                    int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(isEditMode ? "instructor edited succefully" : "instructor added succefully",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("save failed" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Select Excel File";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string excelFilepath = openFileDialog.FileName;
                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(excelFilepath);
                    Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                    using (SqlConnection con = new SqlConnection(DBconnection.conn))
                    {
                        con.Open();

                        for (int row = 2; row <= excelWorksheet.UsedRange.Rows.Count; row++)
                        {
                            string name = excelWorksheet.Cells[row, 2].Value?.ToString() ?? "";
                            string phone = excelWorksheet.Cells[row, 3].Value?.ToString() ?? "";
                            string email = excelWorksheet.Cells[row, 4].Value?.ToString() ?? "";

                            string sqlQuery = "INSERT INTO Instructors (full_name, phone, email)" +
                                "  VALUES (@full_name, @phone, @email)";
                            using (SqlCommand com = new SqlCommand(sqlQuery, con))
                            {
                                com.Parameters.AddWithValue("@full_name", name);
                                com.Parameters.AddWithValue("@phone", phone);
                                com.Parameters.AddWithValue("@email", email);
                                com.ExecuteNonQuery();
                            }
                        }
                    }
                    excelWorkbook.Close();
                    excelApp.Quit();



                    MessageBox.Show("done successfilly");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }
    }
}
