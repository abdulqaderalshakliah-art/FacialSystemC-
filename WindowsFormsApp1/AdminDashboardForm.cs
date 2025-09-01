using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is Button clickedButton)) return;

            string tag = clickedButton.Tag.ToString();

            switch (tag)
            {
                case "dashboard":
                    ShowDashboard();
                    break;
                case "students":
                    ShowStudentManagement();
                    break;
                case "instructors":
                    MessageBox.Show("Opening Instructor Management...");
                    break;
                case "faculties":
                    MessageBox.Show("Opening Faculty & Departments...");
                    break;
                case "courses":
                    MessageBox.Show("Opening Course Management...");
                    break;
                case "attendance":
                    MessageBox.Show("Opening Attendance...");
                    break;
                case "reports":
                    MessageBox.Show("Opening Reports & Analytics...");
                    break;
                case "settings":
                    MessageBox.Show("Opening System Settings...");
                    break;
            }
        }

        private void ShowDashboard()
        {
            // Dashboard is already shown by default
        }

        private void ShowStudentManagement()
        {
            this.Close();
            StudentManagementForm student = new StudentManagementForm();
            student.Show();
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel card = (Panel)sender;
            using (var pen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Set tags for menu buttons
            btnDashboard.Tag = "dashboard";
            btnStudents.Tag = "students";
            btnInstructors.Tag = "instructors";
            btnFaculties.Tag = "faculties";
            btnCourses.Tag = "courses";
            btnAttendance.Tag = "attendance";
            btnReports.Tag = "reports";
            btnSettings.Tag = "settings";
        }
    }
}