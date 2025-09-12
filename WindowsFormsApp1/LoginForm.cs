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

        DBconnection DB= new DBconnection();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact system administrator for password recovery.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            string connectionString = @"Data Source=DESKTOP-6H2GG0Q\SQLEXPRESS;Initial Catalog=FacialSystem;Integrated Security=True;TrustServerCertificate=True";

            if (AuthenticateAdmin(username, password, connectionString))
            {
                MessageBox.Show("Login successful!");
                AdminDashboardForm dashboard = new AdminDashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateAdmin(string username, string password, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Admins WHERE username = @username AND password_hash = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during authentication: " + ex.Message);
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}