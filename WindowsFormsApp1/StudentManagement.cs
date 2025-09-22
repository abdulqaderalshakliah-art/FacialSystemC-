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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        public void LoadStudents()
        {
            string sql = @" SELECT  s.student_id, s.student_code, s.full_name, s.phone, d.department_name AS Department, s.photo
                          FROM Students s  INNER JOIN Departments d ON s.department_id = d.department_id  ORDER BY s.student_id";


            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    adapter.Fill(dt);
                }
            }

            dataGridViewStudents.DataSource = dt;
            
            if (dataGridViewStudents.Columns["student_id"] != null)
            {
                dataGridViewStudents.Columns["student_id"].HeaderText = "ID";
            }
            // Optional: Hide photo_path column
            if (dataGridViewStudents.Columns["photo"] != null)
                dataGridViewStudents.Columns["photo"].HeaderText = "photo";
                

            // Optional: Rename headers
            if (dataGridViewStudents.Columns["full_name"] != null)
                dataGridViewStudents.Columns["full_name"].HeaderText = "Full Name";

            if (dataGridViewStudents.Columns["phone"] != null)
                dataGridViewStudents.Columns["phone"].HeaderText = "Phone";
        }
        private void addmenu_Click(object sender, EventArgs e)
        {
            using (var form = new AddStudents())
            {
                form.Owner = this;
                form.ShowDialog();
            }
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
        
            string filter = txtsearch.Text.Trim();

            if (string.IsNullOrEmpty(filter))
            {
                LoadStudents();
            }
            else
            {
                DataTable dt = ((DataTable)dataGridViewStudents.DataSource);
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"student_code LIKE '%{filter}%' OR full_name LIKE '%{filter}%' OR phone LIKE '%{filter}%' OR Department LIKE '%{filter}%'";
                dataGridViewStudents.DataSource = dv;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }

