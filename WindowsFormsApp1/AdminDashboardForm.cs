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

        private Button selectedButton;

        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is Button clickedButton)) return;

            // Reset previous selected button
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(52, 73, 94); // Default color
            }

            // Set new selected button
            selectedButton = clickedButton;
            selectedButton.BackColor = Color.FromArgb(28, 96, 165); // Hover color


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

                    MessageBox.Show("Opening Course Management...");
                    break;
                case "faculties":
                    ShowFacultyManagement();
                    break;
                case "courses":
                    ShowCourseManagment();
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

            contentpanel.Controls.Clear();
            Label label = new Label();
            label.Text = "Welcome to Admin Dashboard";
            label.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.BackColor = Color.Transparent;

            contentpanel.Controls.Add(label);

        }

        private void ShowStudentManagement()
        {


        }

        private void ShowFacultyManagement()
        {
            contentpanel.Controls.Clear();

            var form = new FacultyManagement();
            form.TopLevel = false;
            contentpanel.Controls.Add(form);
            form.Show();

        }

        private void ShowCourseManagment()
        {
            contentpanel.Controls.Clear();

            var form = new CourseManagment();
            form.TopLevel = false;
            contentpanel.Controls.Add(form);
            form.Show();

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



            foreach (Button btn in sidebar.Controls.OfType<Button>())
            {
                btn.BackColor = Color.FromArgb(52, 73, 94);
            }
        }

       

        }

    }
