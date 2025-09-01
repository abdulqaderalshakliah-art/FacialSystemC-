using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace WindowsFormsApp1
{

    public partial class StudentManagementForm : Form
    {

        private string connectionString = @"Data Source=DESKTOP-POL7I1U\SQLEXPRESS;Initial Catalog=FacialSystem;Integrated Security=True;TrustServerCertificate=True";


        public StudentManagementForm()
        {
            InitializeComponent();
            

        }



        private void StudentManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the previous form (assuming it's called MainForm)
            AdminDashboardForm mainForm = new AdminDashboardForm();

            mainForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text))
            {
                MessageBox.Show("Please enter First Name and Last Name.");
                return;
            }

            byte[] photoData = ImageToByteArray(pictureBox1);

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Students 
               (student_code, first_name, last_name, email, phone, photo) 
               VALUES (@code, @firstName, @lastName, @email, @phone, @photo)";


                    using (var cmd = new SqlCommand(sql, conn))
{
                        cmd.Parameters.AddWithValue("@code", GenerateStudentCode);
                        cmd.Parameters.AddWithValue("@firstName", txtFname.Text);
                        cmd.Parameters.AddWithValue("@lastName", txtLname.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@phone",
                            string.IsNullOrEmpty(maskedTextBox1.Text) || maskedTextBox1.Text.Contains("_")
                            ? (object)DBNull.Value
                            : maskedTextBox1.Text);
                        cmd.Parameters.AddWithValue("@photo", photoData ?? (object)DBNull.Value);
                     


                        cmd.ExecuteNonQuery();
}



                    MessageBox.Show("Student added successfully!");
                    ClearFields();
                    LoadStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
        }

        private string GenerateStudentCode
        {
            get
            {
                string prefix = "STU";
                string year = DateTime.Now.Year.ToString();
                int nextId = 1;

                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        var cmd = new SqlCommand("SELECT ISNULL(MAX(student_id), 0) + 1 FROM Students", conn);
                        nextId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch { }

                return $"{prefix}{year}{nextId:D6}";
            }
        }

        private byte[] ImageToByteArray(PictureBox pb)
        {
            if (pb.Image == null) return null;
            using (var ms = new MemoryStream())
            {
                pb.Image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    
        private void ClearFields()
        {
            //  txtStudentCode.Text = GenerateStudentCode();
            txtFname.Text = "";
            txtLname.Text = "";
            maskedTextBox1.Clear();
            pictureBox1.Image = null;
        } 

        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT student_id, student_code, first_name, last_name,email, phone, photo,department_id FROM Students ORDER BY student_id";

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvStudents.Rows.Add(
                                reader["student_id"],
                                reader["student_code"],
                                reader["first_name"],
                                reader["last_name"],
                                 reader["email"],
                                reader["phone"],
                                 reader["photo"],
                                  reader["department_id"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }
    
        private void btnbroswe_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Select Student Photo";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the image into the PictureBox
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
    }
}
    
    



