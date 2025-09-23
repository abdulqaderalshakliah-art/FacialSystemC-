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

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {

      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide login form
            this.Hide(); // Hide login

            var recoveryForm = new passwordRecovery();
            recoveryForm.FormClosed += (s, args) => this.Show(); // Show login when closed
            recoveryForm.ShowDialog();
        }
        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string connectionString = @"Data Source=DESKTOP-POL7I1U\SQLEXPRESS;Initial Catalog=FacialSystem;Integrated Security=True;TrustServerCertificate=True";

            string role = GetRole(username, password, connectionString);

            if (role == "Admin")
            {
                MessageBox.Show("Login successful! Welcome, Admin.");
                AdminDashboardForm dashboard = new AdminDashboardForm();
                dashboard.Show();
                this.Hide();

            }
            else if (role == "professor")
            {
                MessageBox.Show("Login successful! Welcome, Professor.");
                Attendance_Form attendanceForm = new Attendance_Form();
                attendanceForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private string GetRole(string username, string password, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT role 
                FROM Admins 
                WHERE username = @username AND password_hash = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();
                        return result?.ToString(); // Returns "Admin" or "Professor"
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during authentication: " + ex.Message);
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}