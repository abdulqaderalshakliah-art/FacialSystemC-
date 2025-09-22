using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudents : Form
    {
        private string selectedPhotoPath = null;

        public object studentid { get; private set; }

        public AddStudents()
        {
            InitializeComponent();
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            string sql = "SELECT department_id, department_name FROM Departments ORDER BY department_name";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }

            combodepart.DataSource = dt;
            combodepart.DisplayMember = "department_name";
            combodepart.ValueMember = "department_id";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
 
                if (string.IsNullOrWhiteSpace(txtfullname.Text))
                {
                    MessageBox.Show("Please enter full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtfullname.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(maskedphone.Text))
                {
                    MessageBox.Show("Please enter phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    maskedphone.Focus();
                    return;
                }

                if (combodepart.SelectedItem == null)
                {
                    MessageBox.Show("Please select a department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combodepart.Focus();
                    return;
                }

                try
                {
                    int selectedDepartmentId = Convert.ToInt32(combodepart.SelectedValue);

                    int nextId = GetNextStudentId();
                    string studentCode = $"STU{nextId:D4}";

                    string imagesFolder = Path.Combine(Application.StartupPath, "StudentsPhotos");
                    if (!Directory.Exists(imagesFolder))
                        Directory.CreateDirectory(imagesFolder);

                    string fileName = $"{studentCode}{Path.GetExtension(selectedPhotoPath)}";
                    string destPath = Path.Combine(imagesFolder, fileName);

                    if (selectedPhotoPath != null)
                    {
                        File.Copy(selectedPhotoPath, destPath, true);
                    }

                    string sql = @"INSERT INTO Students (student_code, full_name, phone, photo, department_id) 
                       VALUES (@Code, @Name, @Phone, @Photo, @DeptId)";

                    using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                             
                            cmd.Parameters.AddWithValue("@Code", studentCode);
                            cmd.Parameters.AddWithValue("@Name", txtfullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", maskedphone.Text.Trim());
                            cmd.Parameters.AddWithValue("@Photo", fileName);
                            cmd.Parameters.AddWithValue("@DeptId", selectedDepartmentId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    (this.Owner as StudentManagement)?.LoadStudents();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private int GetNextStudentId()
            {
                string sql = "SELECT ISNULL(MAX(student_id), 0) + 1 FROM Students";
                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            ofd.Title = "Select Student Photo";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPhotoPath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(selectedPhotoPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
    }
