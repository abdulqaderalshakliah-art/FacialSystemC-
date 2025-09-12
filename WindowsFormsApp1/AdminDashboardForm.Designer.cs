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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnFaculties = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.statsContainer = new System.Windows.Forms.Panel();
            this.cardAttendance = new System.Windows.Forms.Panel();
            this.lblAttendanceTitle = new System.Windows.Forms.Label();
            this.lblAttendanceValue = new System.Windows.Forms.Label();
            this.lblAttendanceIcon = new System.Windows.Forms.Label();
            this.cardCourses = new System.Windows.Forms.Panel();
            this.lblCoursesTitle = new System.Windows.Forms.Label();
            this.lblCoursesValue = new System.Windows.Forms.Label();
            this.lblCoursesIcon = new System.Windows.Forms.Label();
            this.cardInstructors = new System.Windows.Forms.Panel();
            this.lblInstructorsTitle = new System.Windows.Forms.Label();
            this.lblInstructorsValue = new System.Windows.Forms.Label();
            this.lblInstructorsIcon = new System.Windows.Forms.Label();
            this.cardStudents = new System.Windows.Forms.Panel();
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.lblStudentsValue = new System.Windows.Forms.Label();
            this.lblStudentsIcon = new System.Windows.Forms.Label();
            this.dashboardTitle = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.userWelcome = new System.Windows.Forms.Label();
            this.headerTitle = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.statsContainer.SuspendLayout();
            this.cardAttendance.SuspendLayout();
            this.cardCourses.SuspendLayout();
            this.cardInstructors.SuspendLayout();
            this.cardStudents.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidebar.Controls.Add(this.btnUsers);
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
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(10, 430);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(230, 50);
            this.btnUsers.TabIndex = 7;
            this.btnUsers.Text = "⚙️  Users Managment";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.MenuItem_Click);
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
            this.btnFaculties.Text = "🏫  Faculty & Departments";
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
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.contentPanel.Controls.Add(this.statsContainer);
            this.contentPanel.Controls.Add(this.dashboardTitle);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 68);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(950, 681);
            this.contentPanel.TabIndex = 3;
            // 
            // statsContainer
            // 
            this.statsContainer.Controls.Add(this.cardAttendance);
            this.statsContainer.Controls.Add(this.cardCourses);
            this.statsContainer.Controls.Add(this.cardInstructors);
            this.statsContainer.Controls.Add(this.cardStudents);
            this.statsContainer.Location = new System.Drawing.Point(33, 83);
            this.statsContainer.Name = "statsContainer";
            this.statsContainer.Size = new System.Drawing.Size(884, 120);
            this.statsContainer.TabIndex = 1;
            // 
            // cardAttendance
            // 
            this.cardAttendance.BackColor = System.Drawing.Color.White;
            this.cardAttendance.Controls.Add(this.lblAttendanceTitle);
            this.cardAttendance.Controls.Add(this.lblAttendanceValue);
            this.cardAttendance.Controls.Add(this.lblAttendanceIcon);
            this.cardAttendance.Location = new System.Drawing.Point(660, 0);
            this.cardAttendance.Name = "cardAttendance";
            this.cardAttendance.Padding = new System.Windows.Forms.Padding(15);
            this.cardAttendance.Size = new System.Drawing.Size(200, 100);
            this.cardAttendance.TabIndex = 3;
            this.cardAttendance.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // lblAttendanceTitle
            // 
            this.lblAttendanceTitle.AutoSize = true;
            this.lblAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAttendanceTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblAttendanceTitle.Location = new System.Drawing.Point(15, 60);
            this.lblAttendanceTitle.Name = "lblAttendanceTitle";
            this.lblAttendanceTitle.Size = new System.Drawing.Size(128, 19);
            this.lblAttendanceTitle.TabIndex = 2;
            this.lblAttendanceTitle.Text = "Today\'s Attendance";
            // 
            // lblAttendanceValue
            // 
            this.lblAttendanceValue.AutoSize = true;
            this.lblAttendanceValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAttendanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.lblAttendanceValue.Location = new System.Drawing.Point(50, 10);
            this.lblAttendanceValue.Name = "lblAttendanceValue";
            this.lblAttendanceValue.Size = new System.Drawing.Size(72, 37);
            this.lblAttendanceValue.TabIndex = 1;
            this.lblAttendanceValue.Text = "87%";
            // 
            // lblAttendanceIcon
            // 
            this.lblAttendanceIcon.AutoSize = true;
            this.lblAttendanceIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblAttendanceIcon.Location = new System.Drawing.Point(15, 15);
            this.lblAttendanceIcon.Name = "lblAttendanceIcon";
            this.lblAttendanceIcon.Size = new System.Drawing.Size(43, 30);
            this.lblAttendanceIcon.TabIndex = 0;
            this.lblAttendanceIcon.Text = "✅";
            // 
            // cardCourses
            // 
            this.cardCourses.BackColor = System.Drawing.Color.White;
            this.cardCourses.Controls.Add(this.lblCoursesTitle);
            this.cardCourses.Controls.Add(this.lblCoursesValue);
            this.cardCourses.Controls.Add(this.lblCoursesIcon);
            this.cardCourses.Location = new System.Drawing.Point(440, 0);
            this.cardCourses.Name = "cardCourses";
            this.cardCourses.Padding = new System.Windows.Forms.Padding(15);
            this.cardCourses.Size = new System.Drawing.Size(200, 100);
            this.cardCourses.TabIndex = 2;
            this.cardCourses.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // lblCoursesTitle
            // 
            this.lblCoursesTitle.AutoSize = true;
            this.lblCoursesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCoursesTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCoursesTitle.Location = new System.Drawing.Point(15, 60);
            this.lblCoursesTitle.Name = "lblCoursesTitle";
            this.lblCoursesTitle.Size = new System.Drawing.Size(109, 19);
            this.lblCoursesTitle.TabIndex = 2;
            this.lblCoursesTitle.Text = "Current Courses";
            // 
            // lblCoursesValue
            // 
            this.lblCoursesValue.AutoSize = true;
            this.lblCoursesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCoursesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblCoursesValue.Location = new System.Drawing.Point(50, 10);
            this.lblCoursesValue.Name = "lblCoursesValue";
            this.lblCoursesValue.Size = new System.Drawing.Size(49, 37);
            this.lblCoursesValue.TabIndex = 1;
            this.lblCoursesValue.Text = "32";
            // 
            // lblCoursesIcon
            // 
            this.lblCoursesIcon.AutoSize = true;
            this.lblCoursesIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblCoursesIcon.Location = new System.Drawing.Point(15, 15);
            this.lblCoursesIcon.Name = "lblCoursesIcon";
            this.lblCoursesIcon.Size = new System.Drawing.Size(41, 30);
            this.lblCoursesIcon.TabIndex = 0;
            this.lblCoursesIcon.Text = "📚";
            // 
            // cardInstructors
            // 
            this.cardInstructors.BackColor = System.Drawing.Color.White;
            this.cardInstructors.Controls.Add(this.lblInstructorsTitle);
            this.cardInstructors.Controls.Add(this.lblInstructorsValue);
            this.cardInstructors.Controls.Add(this.lblInstructorsIcon);
            this.cardInstructors.Location = new System.Drawing.Point(220, 0);
            this.cardInstructors.Name = "cardInstructors";
            this.cardInstructors.Padding = new System.Windows.Forms.Padding(15);
            this.cardInstructors.Size = new System.Drawing.Size(200, 100);
            this.cardInstructors.TabIndex = 1;
            this.cardInstructors.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // lblInstructorsTitle
            // 
            this.lblInstructorsTitle.AutoSize = true;
            this.lblInstructorsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstructorsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblInstructorsTitle.Location = new System.Drawing.Point(15, 60);
            this.lblInstructorsTitle.Name = "lblInstructorsTitle";
            this.lblInstructorsTitle.Size = new System.Drawing.Size(116, 19);
            this.lblInstructorsTitle.TabIndex = 2;
            this.lblInstructorsTitle.Text = "Active Instructors";
            // 
            // lblInstructorsValue
            // 
            this.lblInstructorsValue.AutoSize = true;
            this.lblInstructorsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblInstructorsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            this.lblInstructorsValue.Location = new System.Drawing.Point(50, 10);
            this.lblInstructorsValue.Name = "lblInstructorsValue";
            this.lblInstructorsValue.Size = new System.Drawing.Size(49, 37);
            this.lblInstructorsValue.TabIndex = 1;
            this.lblInstructorsValue.Text = "48";
            // 
            // lblInstructorsIcon
            // 
            this.lblInstructorsIcon.AutoSize = true;
            this.lblInstructorsIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblInstructorsIcon.Location = new System.Drawing.Point(15, 15);
            this.lblInstructorsIcon.Name = "lblInstructorsIcon";
            this.lblInstructorsIcon.Size = new System.Drawing.Size(43, 30);
            this.lblInstructorsIcon.TabIndex = 0;
            this.lblInstructorsIcon.Text = "👨‍🏫";
            // 
            // cardStudents
            // 
            this.cardStudents.BackColor = System.Drawing.Color.White;
            this.cardStudents.Controls.Add(this.lblStudentsTitle);
            this.cardStudents.Controls.Add(this.lblStudentsValue);
            this.cardStudents.Controls.Add(this.lblStudentsIcon);
            this.cardStudents.Location = new System.Drawing.Point(0, 0);
            this.cardStudents.Name = "cardStudents";
            this.cardStudents.Padding = new System.Windows.Forms.Padding(15);
            this.cardStudents.Size = new System.Drawing.Size(200, 100);
            this.cardStudents.TabIndex = 0;
            this.cardStudents.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // lblStudentsTitle
            // 
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStudentsTitle.Location = new System.Drawing.Point(15, 60);
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.Size = new System.Drawing.Size(96, 19);
            this.lblStudentsTitle.TabIndex = 2;
            this.lblStudentsTitle.Text = "Total Students";
            // 
            // lblStudentsValue
            // 
            this.lblStudentsValue.AutoSize = true;
            this.lblStudentsValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStudentsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.lblStudentsValue.Location = new System.Drawing.Point(50, 10);
            this.lblStudentsValue.Name = "lblStudentsValue";
            this.lblStudentsValue.Size = new System.Drawing.Size(88, 37);
            this.lblStudentsValue.TabIndex = 1;
            this.lblStudentsValue.Text = "1,247";
            // 
            // lblStudentsIcon
            // 
            this.lblStudentsIcon.AutoSize = true;
            this.lblStudentsIcon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblStudentsIcon.Location = new System.Drawing.Point(15, 15);
            this.lblStudentsIcon.Name = "lblStudentsIcon";
            this.lblStudentsIcon.Size = new System.Drawing.Size(43, 30);
            this.lblStudentsIcon.TabIndex = 0;
            this.lblStudentsIcon.Text = "🎓";
            // 
            // dashboardTitle
            // 
            this.dashboardTitle.AutoSize = true;
            this.dashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.dashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dashboardTitle.Location = new System.Drawing.Point(23, 23);
            this.dashboardTitle.Name = "dashboardTitle";
            this.dashboardTitle.Size = new System.Drawing.Size(295, 32);
            this.dashboardTitle.TabIndex = 0;
            this.dashboardTitle.Text = "DASHBOARD OVERVIEW";
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.mainContainer.Controls.Add(this.contentPanel);
            this.mainContainer.Controls.Add(this.sidebar);
            this.mainContainer.Controls.Add(this.headerPanel);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1200, 749);
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
            this.headerPanel.Size = new System.Drawing.Size(1200, 68);
            this.headerPanel.TabIndex = 2;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.Transparent;
            this.userPanel.Controls.Add(this.logoutBtn);
            this.userPanel.Controls.Add(this.userWelcome);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userPanel.Location = new System.Drawing.Point(1000, 0);
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
            this.headerTitle.Size = new System.Drawing.Size(1200, 68);
            this.headerTitle.TabIndex = 0;
            this.headerTitle.Text = "FACIAL ATTENDANCE SYSTEM";
            this.headerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Text = "Facial Attendance System - Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.sidebar.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.statsContainer.ResumeLayout(false);
            this.cardAttendance.ResumeLayout(false);
            this.cardAttendance.PerformLayout();
            this.cardCourses.ResumeLayout(false);
            this.cardCourses.PerformLayout();
            this.cardInstructors.ResumeLayout(false);
            this.cardInstructors.PerformLayout();
            this.cardStudents.ResumeLayout(false);
            this.cardStudents.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnFaculties;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnStudents;

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel statsContainer;
        private System.Windows.Forms.Panel cardStudents;
        private System.Windows.Forms.Label lblStudentsTitle;
        private System.Windows.Forms.Label lblStudentsValue;
        private System.Windows.Forms.Label lblStudentsIcon;
        private System.Windows.Forms.Panel cardInstructors;
        private System.Windows.Forms.Label lblInstructorsTitle;
        private System.Windows.Forms.Label lblInstructorsValue;
        private System.Windows.Forms.Label lblInstructorsIcon;
        private System.Windows.Forms.Panel cardCourses;
        private System.Windows.Forms.Label lblCoursesTitle;
        private System.Windows.Forms.Label lblCoursesValue;
        private System.Windows.Forms.Label lblCoursesIcon;
        private System.Windows.Forms.Panel cardAttendance;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblAttendanceValue;
        private System.Windows.Forms.Label lblAttendanceIcon;
        private System.Windows.Forms.Label dashboardTitle;

        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label userWelcome;
        private System.Windows.Forms.Label headerTitle;

        private System.Windows.Forms.Panel contentpanel;

    }
}