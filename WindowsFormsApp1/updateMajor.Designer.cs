namespace WindowsFormsApp1
{
    partial class updateMajor
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
            this.label1 = new System.Windows.Forms.Label();
            this.combfaculty = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combmajor = new System.Windows.Forms.ComboBox();
            this.txtupdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Faculty:";
            // 
            // combfaculty
            // 
            this.combfaculty.FormattingEnabled = true;
            this.combfaculty.Location = new System.Drawing.Point(158, 18);
            this.combfaculty.Name = "combfaculty";
            this.combfaculty.Size = new System.Drawing.Size(176, 21);
            this.combfaculty.TabIndex = 1;
            this.combfaculty.SelectedIndexChanged += new System.EventHandler(this.combfaculty_SelectedIndexChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnupdate.Location = new System.Drawing.Point(121, 160);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(136, 38);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Major To Update:";
            // 
            // combmajor
            // 
            this.combmajor.FormattingEnabled = true;
            this.combmajor.Location = new System.Drawing.Point(167, 60);
            this.combmajor.Name = "combmajor";
            this.combmajor.Size = new System.Drawing.Size(164, 21);
            this.combmajor.TabIndex = 4;
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(170, 100);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(164, 20);
            this.txtupdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Update Major To:";
            // 
            // updateMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.combmajor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.combfaculty);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "updateMajor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Major";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combfaculty;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combmajor;
        private System.Windows.Forms.TextBox txtupdate;
        private System.Windows.Forms.Label label3;
    }
}