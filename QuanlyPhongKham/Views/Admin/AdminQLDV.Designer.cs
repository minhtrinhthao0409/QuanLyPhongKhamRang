namespace QuanlyPhongKham.Views.Admin
{
    partial class AdminQLDV
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            AdminQLDVQv = new System.Windows.Forms.Button();
            AdminQLDVNameTb = new System.Windows.Forms.TextBox();
            AdminQLDVPricetbx = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            AdminQbtnLDVCx = new System.Windows.Forms.Button();
            AdminQLDVXbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(28, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(700, 377);
            dataGridView1.TabIndex = 0;
            // 
            // AdminQLDVQv
            // 
            AdminQLDVQv.Location = new System.Drawing.Point(619, 26);
            AdminQLDVQv.Name = "AdminQLDVQv";
            AdminQLDVQv.Size = new System.Drawing.Size(94, 29);
            AdminQLDVQv.TabIndex = 1;
            AdminQLDVQv.Text = "Quay về";
            AdminQLDVQv.UseVisualStyleBackColor = true;
            // 
            // AdminQLDVNameTb
            // 
            AdminQLDVNameTb.Location = new System.Drawing.Point(135, 28);
            AdminQLDVNameTb.Name = "AdminQLDVNameTb";
            AdminQLDVNameTb.Size = new System.Drawing.Size(176, 27);
            AdminQLDVNameTb.TabIndex = 2;
            // 
            // AdminQLDVPricetbx
            // 
            AdminQLDVPricetbx.Location = new System.Drawing.Point(135, 75);
            AdminQLDVPricetbx.Name = "AdminQLDVPricetbx";
            AdminQLDVPricetbx.Size = new System.Drawing.Size(176, 27);
            AdminQLDVPricetbx.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên Dịch vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Giá Dịch vụ";
            // 
            // AdminQbtnLDVCx
            // 
            AdminQbtnLDVCx.Location = new System.Drawing.Point(409, 26);
            AdminQbtnLDVCx.Name = "AdminQbtnLDVCx";
            AdminQbtnLDVCx.Size = new System.Drawing.Size(94, 29);
            AdminQbtnLDVCx.TabIndex = 6;
            AdminQbtnLDVCx.Text = "Chỉnh sửa";
            AdminQbtnLDVCx.UseVisualStyleBackColor = true;
            // 
            // AdminQLDVXbtn
            // 
            AdminQLDVXbtn.Location = new System.Drawing.Point(409, 75);
            AdminQLDVXbtn.Name = "AdminQLDVXbtn";
            AdminQLDVXbtn.Size = new System.Drawing.Size(94, 29);
            AdminQLDVXbtn.TabIndex = 7;
            AdminQLDVXbtn.Text = "Xóa";
            AdminQLDVXbtn.UseVisualStyleBackColor = true;
            // 
            // AdminQLDV
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 545);
            Controls.Add(AdminQLDVXbtn);
            Controls.Add(AdminQbtnLDVCx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdminQLDVPricetbx);
            Controls.Add(AdminQLDVNameTb);
            Controls.Add(AdminQLDVQv);
            Controls.Add(dataGridView1);
            Name = "AdminQLDV";
            Text = "AdminQLDV";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdminQLDVQv;
        private System.Windows.Forms.TextBox AdminQLDVNameTb;
        private System.Windows.Forms.TextBox AdminQLDVPricetbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminQbtnLDVCx;
        private System.Windows.Forms.Button AdminQLDVXbtn;
    }
}