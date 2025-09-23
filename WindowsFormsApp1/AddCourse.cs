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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace WindowsFormsApp1
{
    public partial class AddCourse : Form
    {
        private DBconnection dbHelper;
        private int courseId;
        private bool isEditMode;

        public AddCourse()
        {
            InitializeComponent();
            dbHelper = new DBconnection();
            isEditMode = false;
        }

        public AddCourse(int id) : this()
        {
            courseId = id;
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

        private void LoadInstructors(int departmentId)
        {
            string query = "SELECT instructor_id, first_name + ' ' + last_name as display_name FROM Instructors WHERE department_id = @departmentId ORDER BY first_name, last_name";
            var parameters = new[] { new System.Data.SqlClient.SqlParameter("@departmentId", departmentId) };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            cmbInstructors.DataSource = dt;
            cmbInstructors.DisplayMember = "display_name";
            cmbInstructors.ValueMember = "instructor_id";
        }

        private void LoadCourseData()
        {
            string query = @"SELECT c.course_name, c.course_code, d.department_id, d.faculty_id, c.instructor_id
                           FROM Courses c
                           INNER JOIN Departments d ON c.department_id = d.department_id
                           WHERE c.course_id = @courseId";

            var parameters = new[] { new System.Data.SqlClient.SqlParameter("@courseId", courseId) };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtCourseName.Text = row["course_name"].ToString();
                txtCourseCode.Text = row["course_code"].ToString();

                // Load faculty and department
                int facultyId = Convert.ToInt32(row["faculty_id"]);
                cmbFaculties.SelectedValue = facultyId;
                LoadDepartments(facultyId);

                int departmentId = Convert.ToInt32(row["department_id"]);
                cmbDepartments.SelectedValue = departmentId;
                LoadInstructors(departmentId);

                cmbInstructors.SelectedValue = Convert.ToInt32(row["instructor_id"]);
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            LoadFaculties();

            if (isEditMode)
            {
                LoadCourseData();
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
            if (cmbDepartments.SelectedValue != null)
            {
                int departmentId = Convert.ToInt32(cmbDepartments.SelectedValue);
                LoadInstructors(departmentId);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("enter course name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCourseCode.Text))
            {
                MessageBox.Show("enter course code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourseCode.Focus();
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

            if (cmbInstructors.SelectedValue == null)
            {
                MessageBox.Show("enter instructor name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInstructors.Focus();
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
                        query = @"UPDATE Courses SET course_name = @courseName, course_code = @courseCode, 
                                 department_id = @departmentId, instructor_id = @instructorId
                                 WHERE course_id = @courseId";

                        parameters = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@courseName", txtCourseName.Text),
                            new System.Data.SqlClient.SqlParameter("@courseCode", txtCourseCode.Text),
                            new System.Data.SqlClient.SqlParameter("@departmentId", cmbDepartments.SelectedValue),
                            new System.Data.SqlClient.SqlParameter("@instructorId", cmbInstructors.SelectedValue),
                            new System.Data.SqlClient.SqlParameter("@courseId", courseId)
                        };
                    }
                    else
                    {
                        query = @"INSERT INTO Courses (course_name, course_code, department_id, instructor_id)
                                 VALUES (@courseName, @courseCode, @departmentId, @instructorId)";

                        parameters = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@courseName", txtCourseName.Text),
                            new System.Data.SqlClient.SqlParameter("@courseCode", txtCourseCode.Text),
                            new System.Data.SqlClient.SqlParameter("@departmentId", cmbDepartments.SelectedValue),
                            new System.Data.SqlClient.SqlParameter("@instructorId", cmbInstructors.SelectedValue)
                        };
                    }

                    int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(isEditMode ? "course edited succefully" : "course added succefully",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" save failed" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string code = excelWorksheet.Cells[row, 3].Value?.ToString() ?? "";
                           
                            string sqlQuery = "Insert into Courses(course_name ,course_code) Values(@course_name , @course_code)";
                            using (SqlCommand com = new SqlCommand(sqlQuery, con))
                            {
                                com.Parameters.AddWithValue("@course_name", name);
                                com.Parameters.AddWithValue("@course_code", code);
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
