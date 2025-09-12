namespace WindowsFormsApp1
{
    partial class AddCourse
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
            this.btnimport = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbInstructors = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFaculties = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnimport
            // 
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnimport.Location = new System.Drawing.Point(320, 254);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(133, 38);
            this.btnimport.TabIndex = 7;
            this.btnimport.Text = "Import File";
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnadd.Location = new System.Drawing.Point(158, 254);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 38);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbInstructors
            // 
            this.cmbInstructors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbInstructors.FormattingEnabled = true;
            this.cmbInstructors.Location = new System.Drawing.Point(183, 184);
            this.cmbInstructors.Name = "cmbInstructors";
            this.cmbInstructors.Size = new System.Drawing.Size(300, 28);
            this.cmbInstructors.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(35, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Instructor name:";
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(183, 144);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(300, 28);
            this.cmbDepartments.TabIndex = 15;
            this.cmbDepartments.SelectedIndexChanged += new System.EventHandler(this.cmbDepartments_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(35, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Department name:";
            // 
            // cmbFaculties
            // 
            this.cmbFaculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFaculties.FormattingEnabled = true;
            this.cmbFaculties.Location = new System.Drawing.Point(183, 104);
            this.cmbFaculties.Name = "cmbFaculties";
            this.cmbFaculties.Size = new System.Drawing.Size(300, 28);
            this.cmbFaculties.TabIndex = 14;
            this.cmbFaculties.SelectedIndexChanged += new System.EventHandler(this.cmbFaculties_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(35, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Faculty name:";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCourseCode.Location = new System.Drawing.Point(183, 64);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(300, 26);
            this.txtCourseCode.TabIndex = 12;
            this.txtCourseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course code:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCourseName.Location = new System.Drawing.Point(183, 24);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(300, 26);
            this.txtCourseName.TabIndex = 11;
            this.txtCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course name:";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 342);
            this.Controls.Add(this.cmbInstructors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFaculties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnadd);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbInstructors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFaculties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label2;
    }
}