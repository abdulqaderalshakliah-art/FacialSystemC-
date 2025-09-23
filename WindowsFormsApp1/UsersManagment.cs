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
    public partial class UsersManagment : Form
    {
        private DBconnection dbHelper;

        public UsersManagment()
        {
            InitializeComponent();
            dbHelper = new DBconnection();
        }

        private void LoadUsers()
        {
            string query = @"select username , email ,role from Admins";

            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewCourses.DataSource = dt;
        }

        private void UsersManagment_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void CourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddUser())
            {
                form.Owner = this; 
                form.ShowDialog();
                LoadUsers();
            }
        }

        private void majorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("select user to edit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int UserId = Convert.ToInt32(dataGridViewCourses.SelectedRows[0].Cells["admin_id"].Value);
            AddUser editForm = new AddUser(UserId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void CourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("selsect user to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int UserId = Convert.ToInt32(dataGridViewCourses.SelectedRows[0].Cells["admin_id"].Value);
            string UserName = dataGridViewCourses.SelectedRows[0].Cells["username"].Value.ToString();

            DialogResult result = MessageBox.Show($"do you want to delete {UserName}؟", "deletation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Admins WHERE admin_id = @id";
                var parameters = new[] { new System.Data.SqlClient.SqlParameter("@id", UserId) };

                try
                {
                    int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("delete done", "suceesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("something went wrong" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For assistance, please contact the system administrators",
            "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtsearch.Text;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(DBconnection.conn))
            {
                connection.Open();

                // ✅ استخدام شرط البحث إذا كان `searchQuery` غير فارغ
                string query = "SELECT ID, username, password_hash FROM Courses WHERE username LIKE @SearchQuery";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            // ✅ تحديث `DataGridView` بالبيانات
            dataGridViewCourses.DataSource = dataTable;

            foreach (DataGridViewRow row in dataGridViewCourses.Rows)
            {
                row.Height = 100; // ضبط ارتفاع الصفوف
            }
        }
    }
}
