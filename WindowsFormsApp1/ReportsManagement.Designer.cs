namespace WindowsFormsApp1
{
    partial class ReportsManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnStu = new System.Windows.Forms.Button();
            this.btnAtt = new System.Windows.Forms.Button();
            this.btnCou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose The Report you want display";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIns
            // 
            this.btnIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIns.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIns.Location = new System.Drawing.Point(34, 108);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(272, 187);
            this.btnIns.TabIndex = 15;
            this.btnIns.Text = "Instructors";
            this.btnIns.UseVisualStyleBackColor = false;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnStu
            // 
            this.btnStu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStu.Location = new System.Drawing.Point(505, 108);
            this.btnStu.Name = "btnStu";
            this.btnStu.Size = new System.Drawing.Size(272, 187);
            this.btnStu.TabIndex = 15;
            this.btnStu.Text = "Students";
            this.btnStu.UseVisualStyleBackColor = false;
            // 
            // btnAtt
            // 
            this.btnAtt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtt.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAtt.Location = new System.Drawing.Point(505, 366);
            this.btnAtt.Name = "btnAtt";
            this.btnAtt.Size = new System.Drawing.Size(272, 187);
            this.btnAtt.TabIndex = 15;
            this.btnAtt.Text = "Attendence";
            this.btnAtt.UseVisualStyleBackColor = false;
            // 
            // btnCou
            // 
            this.btnCou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCou.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCou.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCou.Location = new System.Drawing.Point(34, 366);
            this.btnCou.Name = "btnCou";
            this.btnCou.Size = new System.Drawing.Size(272, 187);
            this.btnCou.TabIndex = 15;
            this.btnCou.Text = "Courses";
            this.btnCou.UseVisualStyleBackColor = false;
            // 
            // ReportsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 603);
            this.Controls.Add(this.btnCou);
            this.Controls.Add(this.btnAtt);
            this.Controls.Add(this.btnStu);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.label2);
            this.Name = "ReportsManagement";
            this.Text = "ReportsManagement";
            this.Load += new System.EventHandler(this.ReportsManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnStu;
        private System.Windows.Forms.Button btnAtt;
        private System.Windows.Forms.Button btnCou;
    }
}