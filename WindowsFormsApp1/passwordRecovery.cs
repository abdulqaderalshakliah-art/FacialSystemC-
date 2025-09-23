using MailKit.Net.Smtp;
using MimeKit;
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
    public partial class passwordRecovery : Form
    {
        public passwordRecovery()
        {
            InitializeComponent();

                this.Text = "Password Recovery";
                this.StartPosition = FormStartPosition.CenterScreen;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Size = new System.Drawing.Size(400, 200);

                // Username Label and TextBox
                Label lblUsername = new Label { Text = "Username:", Location = new System.Drawing.Point(20, 20), AutoSize = true };
                TextBox txtUsername = new TextBox { Name = "txtUsername", Location = new System.Drawing.Point(120, 20), Width = 240 };

                // Email Label and TextBox
                Label lblEmail = new Label { Text = "Email:", Location = new System.Drawing.Point(20, 60), AutoSize = true };
                TextBox txtEmail = new TextBox { Name = "txtEmail", Location = new System.Drawing.Point(120, 60), Width = 240 };

                // Buttons
                Button btnSend = new Button { Text = "Send New Password", Location = new System.Drawing.Point(20, 100) };
            btnSend.Click += async (s, e) =>
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please enter both username and email.");
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                if (!UsernameExists(username))
                {
                    MessageBox.Show("Username not found.");
                    return;
                }

                string newPassword = GenerateRandomPassword(8);
                if (!UpdatePasswordInDB(username, newPassword))
                {
                    MessageBox.Show("Failed to update password in database.");
                    return;
                }

                // ✅ Use 'await' instead of '.Result'
                bool sent = await SendNewPasswordEmail(email, username, newPassword);

                if (sent)
                {
                    MessageBox.Show($"A new password has been sent to {email}.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Return to login
                }
            };

            Button btnCancel = new Button { Text = "Cancel", Location = new Point(180, 100) };
                btnCancel.Click += (s, e) => this.Close();

                // Add controls
                this.Controls.Add(lblUsername);
                this.Controls.Add(txtUsername);
                this.Controls.Add(lblEmail);
                this.Controls.Add(txtEmail);
                this.Controls.Add(btnSend);
                this.Controls.Add(btnCancel);
            }

            private bool UsernameExists(string username)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                    {
                        string query = "SELECT COUNT(*) FROM Admins WHERE username = @username";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            conn.Open();
                            int count = (int)cmd.ExecuteScalar();
                            return count > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false;
                }
            }

            private bool UpdatePasswordInDB(string username, string newPassword)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                    {
                        string query = "UPDATE Admins SET password_hash = @password WHERE username = @username";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", newPassword);
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating password: " + ex.Message);
                    return false;
                }
            }

            private string GenerateRandomPassword(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var sb = new StringBuilder();
                var rand = new Random();
                for (int i = 0; i < length; i++)
                {
                    sb.Append(chars[rand.Next(chars.Length)]);
                }
                return sb.ToString();
            }

            private bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            private async Task<bool> SendNewPasswordEmail(string toEmail, string username, string newPassword)
            {
                try
                {
                    var email = new MimeMessage();
                    email.From.Add(new MailboxAddress("Facial System", "abdulqaderalshakliah@gmail.com"));
                    email.To.Add(new MailboxAddress("", toEmail));
                    email.Subject = "Your New Password";

                    email.Body = new MimeKit.TextPart(MimeKit.Text.TextFormat.Html)
                    {
                        Text = $@"
                        <h2>Password Reset</h2>
                        <p>Hello <strong>{username}</strong>,</p>
                        <p>Your password has been reset.</p>
                        <p><strong>New Password:</strong> <span style='color: red;'>{newPassword}</span></p>
                        <p>You can now log in with this password.</p>"
                    };

                    using (var smtp = new SmtpClient())
                    {
                        await smtp.ConnectAsync("smtp.gmail.com", 587, false);
                        await smtp.AuthenticateAsync("ahmed300asdf10@gmail.com", "epnu hfqo xggb yqab");
                        await smtp.SendAsync(email);
                        await smtp.DisconnectAsync(true);
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email: " + ex.Message);
                    return false;
                }
            }


    

        private void passwordRecovery_Load(object sender, EventArgs e)
        {

        }
    }
}

