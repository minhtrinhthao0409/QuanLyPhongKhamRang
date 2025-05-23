namespace QuanlyPhongKham
{
    partial class QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMatKhau));
            btnLayLaiMatKhau = new System.Windows.Forms.Button();
            btnQuaylai = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblKetQua = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLayLaiMatKhau
            // 
            btnLayLaiMatKhau.AutoSize = true;
            btnLayLaiMatKhau.BackColor = System.Drawing.Color.Blue;
            btnLayLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLayLaiMatKhau.ForeColor = System.Drawing.Color.White;
            btnLayLaiMatKhau.Location = new System.Drawing.Point(278, 558);
            btnLayLaiMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnLayLaiMatKhau.Name = "btnLayLaiMatKhau";
            btnLayLaiMatKhau.Size = new System.Drawing.Size(188, 46);
            btnLayLaiMatKhau.TabIndex = 13;
            btnLayLaiMatKhau.Text = "Lấy Lại Mât Khẩu";
            btnLayLaiMatKhau.UseVisualStyleBackColor = false;
            btnLayLaiMatKhau.Click += btnLayLaiMatKhau_Click;
            // 
            // btnQuaylai
            // 
            btnQuaylai.AutoSize = true;
            btnQuaylai.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
            btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnQuaylai.ForeColor = System.Drawing.Color.White;
            btnQuaylai.Location = new System.Drawing.Point(56, 564);
            btnQuaylai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new System.Drawing.Size(94, 35);
            btnQuaylai.TabIndex = 18;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            txtEmail.Location = new System.Drawing.Point(156, 323);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(352, 29);
            txtEmail.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label4.Location = new System.Drawing.Point(57, 327);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 25);
            label4.TabIndex = 11;
            label4.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label1.Location = new System.Drawing.Point(57, 388);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 25);
            label1.TabIndex = 11;
            label1.Text = "Kết Quả:";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Location = new System.Drawing.Point(156, 392);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new System.Drawing.Size(0, 20);
            lblKetQua.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(156, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(352, 258);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(565, 671);
            Controls.Add(lblKetQua);
            Controls.Add(btnQuaylai);
            Controls.Add(btnLayLaiMatKhau);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "QuenMatKhau";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "QuenMatKhau";
            FormClosing += QuenMatKhau_FormClosing;
            KeyDown += QuenMatKhau_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLayLaiMatKhau;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}