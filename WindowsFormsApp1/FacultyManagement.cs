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
    public partial class FacultyManagement : Form
    {

        private BindingSource bindingSource = new BindingSource();
        public FacultyManagement()
        {
            InitializeComponent();
         
        }
        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddFaculty())
            {
                form.Owner = this; // So it can call LoadFaculties() after saving
                form.ShowDialog(); // Show as dialog (modal)
            }
        }

        internal void LoadFaculties()
        {

            try
            {
                string sql = "SELECT faculty_id, faculty_name FROM Faculties ORDER BY faculty_id ASC";
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                    {
                        adapter.Fill(dt);
                    }
                }

                bindingSource.DataSource = dt;
                dataGridViewFaculties.DataSource = dt;
                
               
                dataGridViewFaculties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                if (dataGridViewFaculties.Columns["faculty_id"] != null)
                {
                    dataGridViewFaculties.Columns["faculty_id"].HeaderText = "ID";
                }

                if (dataGridViewFaculties.Columns["faculty_name"] != null)
                {
                    dataGridViewFaculties.Columns["faculty_name"].HeaderText = "Faculty Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void majorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new AddMajor())
            {
                form.Owner = this; // Critical for refreshing grid
                form.ShowDialog();
            }
        }
        


       
        public void LoadMajors()
        {
            string sql = @"SELECT 
            f.faculty_id,
            f.faculty_name AS FacultyName, d.department_name  FROM Faculties f  LEFT JOIN 
         Departments d ON f.faculty_id = d.faculty_id  ORDER BY f.faculty_id";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }
            bindingSource.DataSource = dt;
            dataGridViewFaculties.DataSource = dt; // ← Uses your DataGridView
         
            dataGridViewFaculties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Reorder columns: ID → Faculty Name → Majors
            if (dataGridViewFaculties.Columns["department_id"] != null)
            {
                dataGridViewFaculties.Columns["department_id"].DisplayIndex = 0;
                dataGridViewFaculties.Columns["department_id"].HeaderText = "ID";
            }

            if (dataGridViewFaculties.Columns["FacultyName"] != null)
            {
                dataGridViewFaculties.Columns["FacultyName"].DisplayIndex = 1;
                dataGridViewFaculties.Columns["FacultyName"].HeaderText = "Faculty Name";
            }
            if (dataGridViewFaculties.Columns["department_name"] != null)
            {
                dataGridViewFaculties.Columns["department_name"].DisplayIndex = 2;
                dataGridViewFaculties.Columns["department_name"].HeaderText = "Majors";
            }
        }

      
      



        private void FacultyManagement_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            LoadMajors();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void majorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new updateMajor())
            {
                form.Owner = this;
                form.ShowDialog();
            }
        }

        private void majorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var form = new DeleteMajor())
            {
                form.Owner = this;
                form.ShowDialog();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "For assistance, please contact the system administrator:\nEng. Abdulqader",
             "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string filter = txtsearch.Text.Trim();

            if (string.IsNullOrEmpty(filter))
            {
                bindingSource.Filter = null; // Show all
            }
            else
            {
                // Filter by ALL visible columns — use your EXACT column names
                bindingSource.Filter = $" department_name LIKE '%{filter}%' OR FacultyName LIKE '%{filter}%'";
            }
        }
    }
    }


