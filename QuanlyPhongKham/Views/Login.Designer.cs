namespace QuanlyPhongKham
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            txtTendangnhap = new System.Windows.Forms.TextBox();
            txtMatKhau = new System.Windows.Forms.TextBox();
            linkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            linkDangKy = new System.Windows.Forms.LinkLabel();
            btnDangNhap = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(81, 49);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(361, 284);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTendangnhap.ForeColor = System.Drawing.Color.Black;
            txtTendangnhap.Location = new System.Drawing.Point(223, 379);
            txtTendangnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new System.Drawing.Size(223, 30);
            txtTendangnhap.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = System.Drawing.Color.Black;
            txtMatKhau.Location = new System.Drawing.Point(220, 461);
            txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new System.Drawing.Size(223, 30);
            txtMatKhau.TabIndex = 3;
            // 
            // linkQuenMatKhau
            // 
            linkQuenMatKhau.AutoSize = true;
            linkQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkQuenMatKhau.Location = new System.Drawing.Point(76, 545);
            linkQuenMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkQuenMatKhau.Name = "linkQuenMatKhau";
            linkQuenMatKhau.Size = new System.Drawing.Size(142, 24);
            linkQuenMatKhau.TabIndex = 4;
            linkQuenMatKhau.TabStop = true;
            linkQuenMatKhau.Text = "Quên Mật Khẩu";
            linkQuenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            linkQuenMatKhau.LinkClicked += linkQuenMatKhau_LinkClicked;
            // 
            // linkDangKy
            // 
            linkDangKy.AutoSize = true;
            linkDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkDangKy.Location = new System.Drawing.Point(365, 545);
            linkDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkDangKy.Name = "linkDangKy";
            linkDangKy.Size = new System.Drawing.Size(81, 24);
            linkDangKy.TabIndex = 5;
            linkDangKy.TabStop = true;
            linkDangKy.Text = "Đăng Ký";
            linkDangKy.LinkClicked += linkDangKy_LinkClicked;
            // 
            // btnDangNhap
            // 
            btnDangNhap.AutoSize = true;
            btnDangNhap.BackColor = System.Drawing.Color.Navy;
            btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = System.Drawing.Color.White;
            btnDangNhap.Location = new System.Drawing.Point(195, 599);
            btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new System.Drawing.Size(133, 46);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label2.Location = new System.Drawing.Point(76, 468);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Mật Khẩu: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
            label1.Location = new System.Drawing.Point(76, 386);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên Tài Khoản:";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(523, 732);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Controls.Add(linkDangKy);
            Controls.Add(linkQuenMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTendangnhap);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += Login_FormClosing;
            KeyDown += Login_KeyDown;
            KeyPress += Login_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.LinkLabel linkDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

