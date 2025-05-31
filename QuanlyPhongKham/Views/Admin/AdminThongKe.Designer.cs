namespace QuanlyPhongKham.Views.Admin
{
    partial class AdminThongKe
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
            AdminBieuDodgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)AdminBieuDodgv).BeginInit();
            SuspendLayout();
            // 
            // AdminBieuDodgv
            // 
            AdminBieuDodgv.AllowUserToAddRows = false;
            AdminBieuDodgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            AdminBieuDodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminBieuDodgv.Location = new System.Drawing.Point(20, 32);
            AdminBieuDodgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AdminBieuDodgv.Name = "AdminBieuDodgv";
            AdminBieuDodgv.RowHeadersWidth = 51;
            AdminBieuDodgv.Size = new System.Drawing.Size(652, 283);
            AdminBieuDodgv.TabIndex = 0;
            AdminBieuDodgv.CellClick += AdminBieuDodgv_CellClick;
            AdminBieuDodgv.CellContentClick += AdminBieuDodgv_CellContentClick;
            // 
            // AdminThongKe
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 338);
            Controls.Add(AdminBieuDodgv);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "AdminThongKe";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AdminBieuDo";
            Load += AdminBieuDo_Load;
            ((System.ComponentModel.ISupportInitialize)AdminBieuDodgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView AdminBieuDodgv;
    }
}