namespace QuanlyPhongKham.Views.Admin
{
    partial class AdminBCTC
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
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            AdminBCTCFromlbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            AdminBCTCData = new System.Windows.Forms.DataGridView();
            AdminBCTCQVbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)AdminBCTCData).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(112, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(112, 90);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // AdminBCTCFromlbl
            // 
            AdminBCTCFromlbl.AutoSize = true;
            AdminBCTCFromlbl.Location = new System.Drawing.Point(35, 37);
            AdminBCTCFromlbl.Name = "AdminBCTCFromlbl";
            AdminBCTCFromlbl.Size = new System.Drawing.Size(62, 20);
            AdminBCTCFromlbl.TabIndex = 2;
            AdminBCTCFromlbl.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Đến ngày";
            // 
            // AdminBCTCData
            // 
            AdminBCTCData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminBCTCData.Location = new System.Drawing.Point(36, 144);
            AdminBCTCData.Name = "AdminBCTCData";
            AdminBCTCData.RowHeadersWidth = 51;
            AdminBCTCData.Size = new System.Drawing.Size(727, 405);
            AdminBCTCData.TabIndex = 4;
            // 
            // AdminBCTCQVbtn
            // 
            AdminBCTCQVbtn.Location = new System.Drawing.Point(657, 30);
            AdminBCTCQVbtn.Name = "AdminBCTCQVbtn";
            AdminBCTCQVbtn.Size = new System.Drawing.Size(94, 29);
            AdminBCTCQVbtn.TabIndex = 5;
            AdminBCTCQVbtn.Text = "Quay về";
            AdminBCTCQVbtn.UseVisualStyleBackColor = true;
            // 
            // AdminBCTC
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(807, 561);
            Controls.Add(AdminBCTCQVbtn);
            Controls.Add(AdminBCTCData);
            Controls.Add(label1);
            Controls.Add(AdminBCTCFromlbl);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "AdminBCTC";
            Text = "AdminBCTC";
            ((System.ComponentModel.ISupportInitialize)AdminBCTCData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label AdminBCTCFromlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AdminBCTCData;
        private System.Windows.Forms.Button AdminBCTCQVbtn;
    }
}