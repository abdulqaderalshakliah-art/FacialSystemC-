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
    public partial class DeleteMajor : Form
    {
        private Dictionary<string, int> facultyIdMap = new Dictionary<string, int>();
        private Dictionary<string, int> majorIdMap = new Dictionary<string, int>();
        public DeleteMajor()
        {
            InitializeComponent();
            LoadFaculties();
        }

        private void LoadFaculties()
        {
            facultyIdMap = loadfaculties.LoadFaculties();

            combfaculty.Items.Clear();
            foreach (string name in facultyIdMap.Keys)
            {
                combfaculty.Items.Add(name);
            }

            combfaculty.SelectedIndex = -1; // فارغ كما طلبت
        }
        private void LoadMajorsByFaculty(int facultyId)
        {
            majorIdMap = loadfaculties.LoadMajorsByFaculty(facultyId);

            combmajor.Items.Clear();
            foreach (string name in majorIdMap.Keys)
            {
                combmajor.Items.Add(name);
            }

            combmajor.SelectedIndex = -1; // فارغ كما طلبت
        }
        private void combfaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // إذا لم يتم اختيار كلية — نفرغ ComboBox التخصصات
            if (combfaculty.SelectedItem == null)
            {
                combmajor.Items.Clear();
                majorIdMap.Clear();
                return;
            }

            string selectedFaculty = combfaculty.SelectedItem.ToString();
            if (!facultyIdMap.TryGetValue(selectedFaculty, out int facultyId)) return;

            LoadMajorsByFaculty(facultyId);
        }
    
      
        private void DeleteMajor_Load(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
       
            if (combfaculty.SelectedItem == null)
            {
                MessageBox.Show("Please select a faculty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combmajor.SelectedItem == null)
            {
                MessageBox.Show("Please select a major to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ أضف رسالة تأكيد قبل الحذف
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this major? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult
.Yes)
            {
                return; // لا نستمر إذا لم يضغط "Yes"
            }

            try
            {
                string selectedMajor = combmajor.SelectedItem.ToString();
                if (!majorIdMap.TryGetValue(selectedMajor, out int majorId))
                {
                    MessageBox.Show("Invalid major selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string sql = "DELETE FROM Departments WHERE department_id = @Id";
                using (SqlConnection conn = new SqlConnection(new DBconnection().conn))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", majorId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Major deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            (this.Owner as FacultyManagement)?.LoadMajors();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No changes made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    