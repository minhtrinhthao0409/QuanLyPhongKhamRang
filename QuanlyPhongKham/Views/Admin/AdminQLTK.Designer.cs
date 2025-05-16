namespace QuanlyPhongKham.Views.Admin
{
    partial class AdminQLTK
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
            AdminQLTKDTGV = new System.Windows.Forms.DataGridView();
            AdminQLTKDXbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)AdminQLTKDTGV).BeginInit();
            SuspendLayout();
            // 
            // AdminQLTKDTGV
            // 
            AdminQLTKDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminQLTKDTGV.Location = new System.Drawing.Point(12, 156);
            AdminQLTKDTGV.Name = "AdminQLTKDTGV";
            AdminQLTKDTGV.RowHeadersWidth = 51;
            AdminQLTKDTGV.Size = new System.Drawing.Size(767, 378);
            AdminQLTKDTGV.TabIndex = 0;
            // 
            // AdminQLTKDXbtn
            // 
            AdminQLTKDXbtn.Location = new System.Drawing.Point(669, 36);
            AdminQLTKDXbtn.Name = "AdminQLTKDXbtn";
            AdminQLTKDXbtn.Size = new System.Drawing.Size(94, 29);
            AdminQLTKDXbtn.TabIndex = 1;
            AdminQLTKDXbtn.Text = "Đăng xuất";
            AdminQLTKDXbtn.UseVisualStyleBackColor = true;
            // 
            // AdminQLTK
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(801, 557);
            Controls.Add(AdminQLTKDXbtn);
            Controls.Add(AdminQLTKDTGV);
            Name = "AdminQLTK";
            Text = "AdminQLTK";
            ((System.ComponentModel.ISupportInitialize)AdminQLTKDTGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView AdminQLTKDTGV;
        private System.Windows.Forms.Button AdminQLTKDXbtn;
    }
}