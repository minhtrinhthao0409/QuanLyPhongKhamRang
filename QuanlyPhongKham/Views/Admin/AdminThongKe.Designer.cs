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
            AdminBieuDodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminBieuDodgv.Location = new System.Drawing.Point(23, 43);
            AdminBieuDodgv.Name = "AdminBieuDodgv";
            AdminBieuDodgv.RowHeadersWidth = 51;
            AdminBieuDodgv.Size = new System.Drawing.Size(745, 377);
            AdminBieuDodgv.TabIndex = 0;
            AdminBieuDodgv.CellClick += AdminBieuDodgv_CellClick;
            AdminBieuDodgv.CellContentClick += AdminBieuDodgv_CellContentClick;
            // 
            // AdminBieuDo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AdminBieuDodgv);
            Name = "AdminBieuDo";
            Text = "AdminBieuDo";
            Load += AdminBieuDo_Load;
            ((System.ComponentModel.ISupportInitialize)AdminBieuDodgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView AdminBieuDodgv;
    }
}