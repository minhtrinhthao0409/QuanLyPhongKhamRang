namespace QuanlyPhongKham
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            btnDangXuat = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(4, 14);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(595, 492);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Location = new System.Drawing.Point(656, 33);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(145, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.AutoSize = true;
            btnDangXuat.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = System.Drawing.Color.White;
            btnDangXuat.Location = new System.Drawing.Point(764, 445);
            btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new System.Drawing.Size(134, 51);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(656, 107);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(232, 211);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(pictureBox2);
            Controls.Add(btnDangXuat);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Home";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}