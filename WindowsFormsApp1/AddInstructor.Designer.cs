namespace WindowsFormsApp1
{
    partial class AddInstructor
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
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFaculties = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(154, 183);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(300, 28);
            this.cmbDepartments.TabIndex = 17;
            this.cmbDepartments.SelectedIndexChanged += new System.EventHandler(this.cmbDepartments_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Major:";
            // 
            // cmbFaculties
            // 
            this.cmbFaculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFaculties.FormattingEnabled = true;
            this.cmbFaculties.Location = new System.Drawing.Point(154, 143);
            this.cmbFaculties.Name = "cmbFaculties";
            this.cmbFaculties.Size = new System.Drawing.Size(300, 28);
            this.cmbFaculties.TabIndex = 15;
            this.cmbFaculties.SelectedIndexChanged += new System.EventHandler(this.cmbFaculties_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Faculty:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(154, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 26);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "email:";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtphone.Location = new System.Drawing.Point(154, 99);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(300, 26);
            this.txtphone.TabIndex = 12;
            this.txtphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "phone number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(154, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(300, 26);
            this.txtFirstName.TabIndex = 11;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Instructor name:";
            // 
            // btnimport
            // 
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnimport.Location = new System.Drawing.Point(321, 265);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(133, 38);
            this.btnimport.TabIndex = 22;
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
            this.btnadd.Location = new System.Drawing.Point(159, 265);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 38);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // AddInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 342);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFaculties);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Name = "AddInstructor";
            this.Text = "AddInstructor";
            this.Load += new System.EventHandler(this.AddInstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFaculties;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnadd;
    }
}