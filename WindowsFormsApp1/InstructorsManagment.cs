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
    public partial class InstructorsManagment : Form
    {
        private DBconnection dbHelper;

        public InstructorsManagment()
        {
            InitializeComponent();
            dbHelper = new DBconnection();
        }

        private void LoadInstructors()
        {
            string query = @"SELECT i.instructor_id, i.full_name, i.email, 
                            d.department_name, f.faculty_name
                            FROM Instructors i
                            INNER JOIN Departments d ON i.department_id = d.department_id
                            INNER JOIN Faculties f ON d.faculty_id = f.faculty_id
                            ORDER BY i.instructor_id DESC";

            DataTable dt = dbHelper.ExecuteQuery(query);
            dataGridViewCourses.DataSource = dt;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InstructorsManagment_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void CourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddInstructor())
            {
                form.Owner = this; 
                form.ShowDialog(); 
                LoadInstructors();
            }
        }

        private void majorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("select Instructor to edit", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int InstructorId = Convert.ToInt32(dataGridViewCourses.SelectedRows[0].Cells["instructor_id"].Value);
            AddInstructor editForm = new AddInstructor(InstructorId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadInstructors();
            }
        }

        private void CourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("selsect Instructor to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int InstructorId = Convert.ToInt32(dataGridViewCourses.SelectedRows[0].Cells["instructor_id"].Value);
            string instructorName = dataGridViewCourses.SelectedRows[0].Cells["full_name"].Value.ToString();

            DialogResult result = MessageBox.Show($"do you want to delete {instructorName}؟", "deletation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Instructors WHERE instructor_id = @id";
                var parameters = new[] { new System.Data.SqlClient.SqlParameter("@id", InstructorId) };

                try
                {
                    int rowsAffected = dbHelper.ExecuteNonQuery(query, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("delete done", "suceesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInstructors();
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
                string query = "SELECT ID, full_name, email , phone , username FROM Instructors WHERE full_name LIKE @SearchQuery";

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
