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
    public partial class CourseManagment : Form
    {
        private DBconnection dbHelper;
        public CourseManagment()
        {
            InitializeComponent();
            dbHelper = new DBconnection();
        }

        private void LoadCourses()
        {
            string query = @"SELECT c.course_id, c.course_name, c.course_code, 
                            d.department_name, i.full_name as instructor_name
                            FROM Courses c
                            INNER JOIN Departments d ON c.department_id = d.department_id
                            INNER JOIN Instructors i ON c.instructor_id = i.instructor_id
                            ORDER BY c.course_id DESC";

            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewCourses.DataSource = dt;
        }
        private void CourseManagment_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void CourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddCourse())
            {
                form.Owner = this; // So it can call LoadFaculties() after saving
                form.ShowDialog(); // Show as dialog (modal)
                LoadCourses();
            }
        }


        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("select course to edit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId = Convert.ToInt32(dataGridViewCourses.SelectedRows[0].Cells["course_id"].Value);
            AddCourse editForm = new AddCourse(courseId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void CourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("selsect subject to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId = Convert.ToInt32(dataGridViewCourses.SelectedRows[0].Cells["course_id"].Value);
            string courseName = dataGridViewCourses.SelectedRows[0].Cells["course_name"].Value.ToString();

            DialogResult result = MessageBox.Show($"do you want to delete {courseName}؟", "deletation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Courses WHERE course_id = @id";
                var parameters = new[] { new System.Data.SqlClient.SqlParameter("@id", courseId) };

                try
                {
                    int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("delete done", "suceesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCourses();
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
                string query = "SELECT ID, course_name, course_code FROM Courses WHERE course_name LIKE @SearchQuery";

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
