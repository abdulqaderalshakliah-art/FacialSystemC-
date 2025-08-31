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
        private TextBox usernameTextBox;
        private Panel mainPanel;
        private Label titleLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label errorLabel;
        private LinkLabel helpLinkLabel;

        public LoginForm()

        {
            InitializeComponent();
        
             // Form properties
            this.Text = "Facial Smart Attendance System - Login";
            this.Size = new Size(400, 550); // Increased height for labels
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Main container panel
            mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

          

            // System title
            titleLabel = new Label
            {
                Text = "Facial Smart Attendance System",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 130)
            };

            // Username Label
            Label usernameLabel = new Label
            {
                Text = "Username",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 170),
                ForeColor = Color.FromArgb(64, 64, 64)
            };

            // Username field
            usernameTextBox = new TextBox
            {
                Size = new Size(300, 35),
                Location = new Point(40, 190),
                Font = new Font("Segoe UI", 11)
            };

            // Password Label
            Label passwordLabel = new Label
            {
                Text = "Password",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 235),
                ForeColor = Color.FromArgb(64, 64, 64)
            };

            // Password field
            passwordTextBox = new TextBox
            {
                Size = new Size(300, 35),
                Location = new Point(40, 255),
                UseSystemPasswordChar = true,
                Font = new Font("Segoe UI", 11)
            };

            // Role Label
            Label roleLabel = new Label
            {
                Text = "Role",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(40, 300),
                ForeColor = Color.FromArgb(64, 64, 64)
            };

       
            // Login button
            loginButton = new Button
            {
                Text = "Login",
                Size = new Size(300, 40),
                Location = new Point(40, 370),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.Click += LoginButton_Click;

            // Error message label
            errorLabel = new Label
            {
                ForeColor = Color.Red,
                Size = new Size(300, 40),
                Location = new Point(40, 420),
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };

            // Help link
            helpLinkLabel = new LinkLabel
            {
                Text = "Forgot password?",
                Size = new Size(300, 20),
                Location = new Point(40, 470),
                TextAlign = ContentAlignment.MiddleCenter
            };
            helpLinkLabel.LinkClicked += HelpLinkLabel_LinkClicked;

       

            // Add controls to panel
            mainPanel.Controls.AddRange(new Control[]
            {
       titleLabel,
        usernameLabel, usernameTextBox,
        passwordLabel, passwordTextBox,
      
        loginButton, errorLabel,
        helpLinkLabel
            });

            // Add panel to form
            this.Controls.Add(mainPanel);
        }

        private void HelpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
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

            // Use proper connection string
            string connectionString = @"Data Source=DESKTOP-POL7I1U\SQLEXPRESS;Initial Catalog=facialSystem;Integrated Security=True;TrustServerCertificate=True";

            if (AuthenticateAdmin(username, password, connectionString))
            {
                // Login successful - open dashboard
                MessageBox.Show("Login successful!");
                AdminDashboardForm dashboard = new AdminDashboardForm();
                dashboard.Show();
                this.Hide(); // Hide login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        // Simple authentication method (no hashing)
        private bool AuthenticateAdmin(string username, string password, string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Admins WHERE username = @username AND password_hash = @password AND role = 'Admin'";

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
