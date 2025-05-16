namespace QuanlyPhongKham.Views.Admin
{
    partial class AdminMain
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
            AdminMainQLTKbtn = new System.Windows.Forms.Button();
            AdminMainQLDVbtn = new System.Windows.Forms.Button();
            AdminBCTCbtn = new System.Windows.Forms.Button();
            AdminDXbtn = new System.Windows.Forms.Button();
            AdminMainNametxt = new System.Windows.Forms.Label();
            AdminMainIDtxt = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // AdminMainQLTKbtn
            // 
            AdminMainQLTKbtn.Location = new System.Drawing.Point(61, 347);
            AdminMainQLTKbtn.Name = "AdminMainQLTKbtn";
            AdminMainQLTKbtn.Size = new System.Drawing.Size(94, 29);
            AdminMainQLTKbtn.TabIndex = 0;
            AdminMainQLTKbtn.Text = "QLTK";
            AdminMainQLTKbtn.UseVisualStyleBackColor = true;
            // 
            // AdminMainQLDVbtn
            // 
            AdminMainQLDVbtn.Location = new System.Drawing.Point(345, 347);
            AdminMainQLDVbtn.Name = "AdminMainQLDVbtn";
            AdminMainQLDVbtn.Size = new System.Drawing.Size(94, 29);
            AdminMainQLDVbtn.TabIndex = 1;
            AdminMainQLDVbtn.Text = "QLDV";
            AdminMainQLDVbtn.UseVisualStyleBackColor = true;
            // 
            // AdminBCTCbtn
            // 
            AdminBCTCbtn.Location = new System.Drawing.Point(632, 347);
            AdminBCTCbtn.Name = "AdminBCTCbtn";
            AdminBCTCbtn.Size = new System.Drawing.Size(94, 29);
            AdminBCTCbtn.TabIndex = 2;
            AdminBCTCbtn.Text = "BCTC";
            AdminBCTCbtn.UseVisualStyleBackColor = true;
            // 
            // AdminDXbtn
            // 
            AdminDXbtn.Location = new System.Drawing.Point(632, 40);
            AdminDXbtn.Name = "AdminDXbtn";
            AdminDXbtn.Size = new System.Drawing.Size(94, 29);
            AdminDXbtn.TabIndex = 3;
            AdminDXbtn.Text = "Đăng xuất";
            AdminDXbtn.UseVisualStyleBackColor = true;
            // 
            // AdminMainNametxt
            // 
            AdminMainNametxt.AutoSize = true;
            AdminMainNametxt.Location = new System.Drawing.Point(65, 34);
            AdminMainNametxt.Name = "AdminMainNametxt";
            AdminMainNametxt.Size = new System.Drawing.Size(49, 20);
            AdminMainNametxt.TabIndex = 4;
            AdminMainNametxt.Text = "Name";
            // 
            // AdminMainIDtxt
            // 
            AdminMainIDtxt.AutoSize = true;
            AdminMainIDtxt.Location = new System.Drawing.Point(65, 73);
            AdminMainIDtxt.Name = "AdminMainIDtxt";
            AdminMainIDtxt.Size = new System.Drawing.Size(24, 20);
            AdminMainIDtxt.TabIndex = 5;
            AdminMainIDtxt.Text = "ID";
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AdminMainIDtxt);
            Controls.Add(AdminMainNametxt);
            Controls.Add(AdminDXbtn);
            Controls.Add(AdminBCTCbtn);
            Controls.Add(AdminMainQLDVbtn);
            Controls.Add(AdminMainQLTKbtn);
            Name = "AdminMain";
            Text = "AdminMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AdminMainQLTKbtn;
        private System.Windows.Forms.Button AdminMainQLDVbtn;
        private System.Windows.Forms.Button AdminBCTCbtn;
        private System.Windows.Forms.Button AdminDXbtn;
        private System.Windows.Forms.Label AdminMainNametxt;
        private System.Windows.Forms.Label AdminMainIDtxt;
    }
}