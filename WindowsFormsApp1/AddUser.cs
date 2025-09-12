using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        private DBconnection dbHelper;
        private int UserId;
        private bool isEditMode;

        public AddUser()
        {
            InitializeComponent();

            dbHelper = new DBconnection();
            isEditMode = false;
        }


        public AddUser(int id) : this()
        {
            UserId = id;
            isEditMode = true;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void LoadUserData()
        {
            string query = @"select username ,password_hash , email ,role from Admins";

            var parameters = new[] { new System.Data.SqlClient.SqlParameter("@admin_id", UserId) };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtUserName.Text = row["username"].ToString();
                txtPassword.Text = row["password_hash"].ToString();
                txtEmail.Text = row["email"].ToString();
                cmbRole.Text= row["role"].ToString();
                // Load faculty and department




            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                LoadUserData();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("enter user name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("enter user password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("enter email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (cmbRole.SelectedValue == null)
            {
                MessageBox.Show("enter role name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
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
                    string PasswordHash = HashPassword(txtPassword.Text);
                    System.Data.SqlClient.SqlParameter[] parameters;

                    if (isEditMode)
                    {
                        query = @"UPDATE Admins SET username = @username, password_hash = @password_hash, 
                                email = @email, role = @role
                                 WHERE admin_id = @UserId";

                        parameters = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@username", txtUserName.Text),
                            new System.Data.SqlClient.SqlParameter("@password_hash",PasswordHash),
                            new System.Data.SqlClient.SqlParameter("@email", txtEmail.Text),
                            new System.Data.SqlClient.SqlParameter("@role", cmbRole.SelectedValue),
                            new System.Data.SqlClient.SqlParameter("@UserId", UserId)
                        };
                    }
                    else
                    {
                        query = @"INSERT INTO Admins (username, password_hash, email, role)
                                 VALUES (@username, @password_hash, @email, @role)";

                        parameters = new System.Data.SqlClient.SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("@username", txtUserName.Text),
                            new System.Data.SqlClient.SqlParameter("@password_hash", PasswordHash),
                            new System.Data.SqlClient.SqlParameter("@email", txtEmail.Text),
                            new System.Data.SqlClient.SqlParameter("@role", cmbRole.SelectedValue)
                        };
                    }

                    int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(isEditMode ? "user edited succefully" : "user added succefully",
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
    }
}
