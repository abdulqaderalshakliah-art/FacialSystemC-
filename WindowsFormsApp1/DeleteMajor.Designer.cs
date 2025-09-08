namespace WindowsFormsApp1
{
    partial class DeleteMajor
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
            this.btndelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combmajor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Faculty:";
            // 
            // combfaculty
            // 
            this.combfaculty.FormattingEnabled = true;
            this.combfaculty.Location = new System.Drawing.Point(131, 38);
            this.combfaculty.Name = "combfaculty";
            this.combfaculty.Size = new System.Drawing.Size(165, 21);
            this.combfaculty.TabIndex = 1;
            this.combfaculty.SelectedIndexChanged += new System.EventHandler(this.combfaculty_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(115, 143);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(127, 42);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Major To Delete:";
            // 
            // combmajor
            // 
            this.combmajor.FormattingEnabled = true;
            this.combmajor.Location = new System.Drawing.Point(175, 87);
            this.combmajor.Name = "combmajor";
            this.combmajor.Size = new System.Drawing.Size(141, 21);
            this.combmajor.TabIndex = 4;
            // 
            // DeleteMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 210);
            this.Controls.Add(this.combmajor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.combfaculty);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeleteMajor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Major";
            this.Load += new System.EventHandler(this.DeleteMajor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combfaculty;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combmajor;
    }
}