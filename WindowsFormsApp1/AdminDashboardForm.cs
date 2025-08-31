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
        // Modern color palette
        private readonly Color primaryColor = Color.FromArgb(52, 73, 94);
        private readonly Color secondaryColor = Color.FromArgb(67, 130, 232);
        private readonly Color accentColor = Color.FromArgb(86, 202, 139);
        private readonly Color backgroundColor = Color.FromArgb(245, 247, 250);
        private readonly Color cardColor = Color.White;
        private readonly Color sidebarColor = Color.FromArgb(35, 37, 59);


        private Panel sidebar;
        private Panel contentPanel;
    

        public AdminDashboardForm()
        {
            InitializeComponent();

            InitializeForm();
            InitializeDashboard();
        }
 

            private void InitializeForm()
            {
                // Form setup
                this.Text = "Facial Attendance System - Admin Dashboard";
                this.Size = new Size(1200, 800);
                this.StartPosition = FormStartPosition.CenterScreen;
                this.BackColor = backgroundColor;
                this.Font = new Font("Segoe UI", 9);

                // Main container
                Panel mainContainer = new Panel();
                mainContainer.Dock = DockStyle.Fill;
                mainContainer.BackColor = backgroundColor;
                this.Controls.Add(mainContainer);

                // Header
                Panel headerPanel = new Panel();
                headerPanel.Dock = DockStyle.Top;
                headerPanel.Height = 68;
                headerPanel.BackColor = primaryColor;
                mainContainer.Controls.Add(headerPanel);

                // Header title
                Label headerTitle = new Label();
                headerTitle.Text = "FACIAL ATTENDANCE SYSTEM";
                headerTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                headerTitle.ForeColor = Color.White;
                headerTitle.Dock = DockStyle.Fill;
                headerTitle.TextAlign = ContentAlignment.MiddleLeft;
                headerTitle.Padding = new Padding(0, 0, 0, 0);
                headerPanel.Controls.Add(headerTitle);

                // User info
                Panel userPanel = new Panel();
                userPanel.Dock = DockStyle.Right;
                userPanel.Width = 200;
                userPanel.BackColor = Color.Transparent;

                Label userWelcome = new Label();
                userWelcome.Text = "Welcome, Admin";
                userWelcome.Font = new Font("Segoe UI", 10);
                userWelcome.ForeColor = Color.White;
                userWelcome.Location = new Point(20, 15);
                userWelcome.AutoSize = true;

                Button logoutBtn = new Button();
                logoutBtn.Text = "Logout";
                logoutBtn.Size = new Size(90, 30);
                logoutBtn.Location = new Point(40, 35);
              //  logoutBtn.FlatStyle = FlatStyle.Flat;
                logoutBtn.BackColor = secondaryColor;
                logoutBtn.ForeColor = Color.White;
                logoutBtn.Click += (s, e) => Logout();

                userPanel.Controls.Add(userWelcome);
                userPanel.Controls.Add(logoutBtn);
                headerPanel.Controls.Add(userPanel);

                // Sidebar
                sidebar = new Panel();
                sidebar.Dock = DockStyle.Left;
                sidebar.Width = 250;
                sidebar.BackColor = sidebarColor;
                mainContainer.Controls.Add(sidebar);

                // Content area
                contentPanel = new Panel();
                contentPanel.Dock = DockStyle.Fill;
                contentPanel.BackColor = backgroundColor;
                contentPanel.Padding = new Padding(30);
                mainContainer.Controls.Add(contentPanel);
            }

            private void InitializeDashboard()
            {
                CreateSidebarMenu();
                LoadDashboardContent();
            }


        private void CreateSidebarMenu()
        {
        
            sidebar.Controls.Clear();
            sidebar.BackColor = Color.FromArgb(44, 62, 80); // Dark blue-gray background

            var menuItems = new[]
            {
        new { Text = "Dashboard", Icon = "📊", Tag = "dashboard" },
        new { Text = "Student Management", Icon = "🎓", Tag = "students" },
        new { Text = "Instructor Management", Icon = "👨‍🏫", Tag = "instructors" },
        new { Text = "Faculty & Departments", Icon = "🏫", Tag = "faculties" },
        new { Text = "Course Management", Icon = "📚", Tag = "courses" },
        new { Text = "Attendance", Icon = "✅", Tag = "attendance" },
        new { Text = "Reports & Analytics", Icon = "📈", Tag = "reports" },
        new { Text = "System Settings", Icon = "⚙️", Tag = "settings" }
    };

            int yPos = 10;

            foreach (var item in menuItems)
            {
                Button menuButton = new Button();
                menuButton.Text = $"{item.Icon}  {item.Text}";
                menuButton.Size = new Size(sidebar.Width - 20, 50);
                menuButton.Location = new Point(10, yPos);
                menuButton.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                menuButton.TextAlign = ContentAlignment.MiddleLeft;
                menuButton.FlatStyle = FlatStyle.Flat;
                menuButton.FlatAppearance.BorderSize = 0;

                // Modern gradient-like colors
                menuButton.BackColor = Color.FromArgb(52, 73, 94);    // Dark blue-gray
                menuButton.ForeColor = Color.White;
                menuButton.Cursor = Cursors.Hand;
                menuButton.Tag = item.Tag;

                // Hover effects
                menuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185); // Blue highlight
                menuButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);  // Darker blue

                // Rounded corners effect
                menuButton.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);

                // Click event
                menuButton.Click += MenuItem_Click;

                sidebar.Controls.Add(menuButton);
                yPos += 60;
            }

        
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
                //case "instructors":
                //    ShowInstructorManagement();
                //    break;
                //case "faculties":
                //    ShowFacultyManagement();
                //    break;
                //case "courses":
                //    ShowCourseManagement();
                //    break;
                //case "attendance":
                //    ShowAttendance();
                //    break;
                //case "reports":
                //    ShowReports();
                //    break;
                //case "settings":
                //    ShowSettings();
                //    break;
            }
        }


        private void ShowDashboard()
        {
            MessageBox.Show("Opening Dashboard...");
            // Your dashboard code here
        }
        private void ShowStudentManagement()
        {
           this.Close();
            StudentManagementForm student = new StudentManagementForm();
            student.Show();
       

        }

        //private void ShowInstructorManagement()
        //{
        //    MessageBox.Show("Opening Instructor Management...");
        //    // Your instructor management code here
        //}

        //private void ShowFacultyManagement()
        //{
        //    MessageBox.Show("Opening Faculty & Departments...");
        //    // Your faculty management code here
        //}

        //private void ShowCourseManagement()
        //{
        //    MessageBox.Show("Opening Course Management...");
        //    // Your course management code here
        //}

        //private void ShowAttendance()
        //{
        //    MessageBox.Show("Opening Attendance...");
        //    // Your attendance code here
        //}

        //private void ShowReports()
        //{
        //    MessageBox.Show("Opening Reports & Analytics...");
        //    // Your reports code here
        //}

        //private void ShowSettings()
        //{
        //    MessageBox.Show("Opening System Settings...");
        //    // Your settings code here
        //}
        private void LoadContent(string tag)
            {
                contentPanel.Controls.Clear();

                switch (tag)
                {
                    case "dashboard":
                        LoadDashboardContent();
                        break;
                    default:
                        Label title = new Label();
                        title.Text = tag.ToUpper();
                        title.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                        title.ForeColor = primaryColor;
                        title.Location = new Point(20, 20);
                        title.AutoSize = true;
                        contentPanel.Controls.Add(title);
                        break;
                }
            }

            private void LoadDashboardContent()
            {
                // Title
                Label title = new Label();
                title.Text = "DASHBOARD OVERVIEW";
                title.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                title.ForeColor = primaryColor;
                title.Location = new Point(20, 20);
                title.AutoSize = true;
                contentPanel.Controls.Add(title);

                // Stats grid
                Panel statsContainer = new Panel();
                statsContainer.Location = new Point(20, 80);
                statsContainer.Size = new Size(contentPanel.Width - 80, 120);

                var stats = new[]
                {
                new { Title = "Total Students", Value = "1,247", Color = secondaryColor, Icon = "🎓" },
                new { Title = "Active Instructors", Value = "48", Color = accentColor, Icon = "👨‍🏫" },
                new { Title = "Current Courses", Value = "32", Color = Color.FromArgb(255, 140, 0), Icon = "📚" },
                new { Title = "Today's Attendance", Value = "87%", Color = Color.FromArgb(155, 89, 182), Icon = "✅" }
            };

                int xPos = 0;
                foreach (var stat in stats)
                {
                    Panel statCard = CreateStatCard(stat.Title, stat.Value, stat.Icon, stat.Color);
                    statCard.Location = new Point(xPos, 0);
                    statsContainer.Controls.Add(statCard);
                    xPos += 220;
                }

                contentPanel.Controls.Add(statsContainer);
            }

            private Panel CreateStatCard(string title, string value, string icon, Color color)
            {
                Panel card = new Panel();
                card.Size = new Size(200, 100);
                card.BackColor = cardColor;
                card.Padding = new Padding(15);
                card.BorderStyle = BorderStyle.None;

                // Simple shadow effect using border
                card.Paint += (s, e) =>
                {
                    // Draw a subtle border for depth
                    using (var pen = new Pen(Color.FromArgb(30, 0, 0, 0), 1))
                    {
                        e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                    }
                };

                // Icon
                Label iconLabel = new Label();
                iconLabel.Text = icon;
                iconLabel.Font = new Font("Segoe UI", 16);
                iconLabel.Location = new Point(15, 15);
                iconLabel.AutoSize = true;

                // Value
                Label valueLabel = new Label();
                valueLabel.Text = value;
                valueLabel.Font = new Font("Segoe UI", 20, FontStyle.Bold);
                valueLabel.ForeColor = color;
                valueLabel.Location = new Point(50, 10);
                valueLabel.AutoSize = true;

                // Title
                Label titleLabel = new Label();
                titleLabel.Text = title;
                titleLabel.Font = new Font("Segoe UI", 10);
                titleLabel.ForeColor = Color.Gray;
                titleLabel.Location = new Point(15, 60);
                titleLabel.AutoSize = true;

                card.Controls.Add(iconLabel);
                card.Controls.Add(valueLabel);
                card.Controls.Add(titleLabel);

                return card;
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

        }
    }
}
