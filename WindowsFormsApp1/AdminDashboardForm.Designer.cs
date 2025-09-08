namespace WindowsFormsApp1
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnFaculties = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userWelcome = new System.Windows.Forms.Label();
            this.headerTitle = new System.Windows.Forms.Label();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidebar.Controls.Add(this.btnSettings);
            this.sidebar.Controls.Add(this.btnReports);
            this.sidebar.Controls.Add(this.btnAttendance);
            this.sidebar.Controls.Add(this.btnCourses);
            this.sidebar.Controls.Add(this.btnFaculties);
            this.sidebar.Controls.Add(this.btnInstructors);
            this.sidebar.Controls.Add(this.btnStudents);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 68);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(250, 681);
            this.sidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(10, 430);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(230, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "⚙️  System Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(10, 370);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(230, 50);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "📈  Reports & Analytics";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(10, 310);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(230, 50);
            this.btnAttendance.TabIndex = 5;
            this.btnAttendance.Text = "✅  Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCourses.ForeColor = System.Drawing.Color.White;
            this.btnCourses.Location = new System.Drawing.Point(10, 250);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(230, 50);
            this.btnCourses.TabIndex = 4;
            this.btnCourses.Text = "📚  Course Management";
            this.btnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnFaculties
            // 
            this.btnFaculties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnFaculties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnFaculties.FlatAppearance.BorderSize = 0;
            this.btnFaculties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnFaculties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnFaculties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaculties.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFaculties.ForeColor = System.Drawing.Color.White;
            this.btnFaculties.Location = new System.Drawing.Point(10, 190);
            this.btnFaculties.Name = "btnFaculties";
            this.btnFaculties.Size = new System.Drawing.Size(230, 50);
            this.btnFaculties.TabIndex = 3;
            this.btnFaculties.Text = "🏫  Faculty Management";
            this.btnFaculties.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFaculties.UseVisualStyleBackColor = false;
            this.btnFaculties.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnInstructors
            // 
            this.btnInstructors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnInstructors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnInstructors.FlatAppearance.BorderSize = 0;
            this.btnInstructors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnInstructors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInstructors.ForeColor = System.Drawing.Color.White;
            this.btnInstructors.Location = new System.Drawing.Point(10, 130);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(230, 50);
            this.btnInstructors.TabIndex = 2;
            this.btnInstructors.Text = "👨‍🏫  Instructor Management";
            this.btnInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructors.UseVisualStyleBackColor = false;
            this.btnInstructors.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(10, 70);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(230, 50);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "🎓  Student Management";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(10, 10);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(230, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "📊  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.mainContainer.Controls.Add(this.contentpanel);
            this.mainContainer.Controls.Add(this.sidebar);
            this.mainContainer.Controls.Add(this.headerPanel);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1199, 749);
            this.mainContainer.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.headerPanel.Controls.Add(this.userPanel);
            this.headerPanel.Controls.Add(this.headerTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1199, 68);
            this.headerPanel.TabIndex = 2;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.Transparent;
            this.userPanel.Controls.Add(this.logoutBtn);
            this.userPanel.Controls.Add(this.userWelcome);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userPanel.Location = new System.Drawing.Point(999, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(200, 68);
            this.userPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(40, 35);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(90, 30);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // userWelcome
            // 
            this.userWelcome.AutoSize = true;
            this.userWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.userWelcome.ForeColor = System.Drawing.Color.White;
            this.userWelcome.Location = new System.Drawing.Point(20, 15);
            this.userWelcome.Name = "userWelcome";
            this.userWelcome.Size = new System.Drawing.Size(111, 19);
            this.userWelcome.TabIndex = 0;
            this.userWelcome.Text = "Welcome, Admin";
            // 
            // headerTitle
            // 
            this.headerTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.headerTitle.ForeColor = System.Drawing.Color.White;
            this.headerTitle.Location = new System.Drawing.Point(0, 0);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(1199, 68);
            this.headerTitle.TabIndex = 0;
            this.headerTitle.Text = "FACIAL ATTENDANCE SYSTEM";
            this.headerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentpanel
            // 
            this.contentpanel.Location = new System.Drawing.Point(247, 68);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(952, 681);
            this.contentpanel.TabIndex = 3;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facial Attendance System";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.sidebar.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnFaculties;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label userWelcome;
        private System.Windows.Forms.Label headerTitle;
        private System.Windows.Forms.Panel contentpanel;
    }
}