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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            AdminMainDXbtn = new System.Windows.Forms.Button();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            AdminIDtb = new System.Windows.Forms.TextBox();
            AdminNametb = new System.Windows.Forms.TextBox();
            AdminMainIDlbl = new System.Windows.Forms.Label();
            AdminMainNamelbl = new System.Windows.Forms.Label();
            AdminBCTC = new System.Windows.Forms.TabPage();
            AdminBCTCRevtbx = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            AdminBCTCXuatbtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            AdminBCTCFromlbl = new System.Windows.Forms.Label();
            AdminBCTCFToTP = new System.Windows.Forms.DateTimePicker();
            AdminBCTCFromTP = new System.Windows.Forms.DateTimePicker();
            AdminBCTCdgv = new System.Windows.Forms.DataGridView();
            tabPage2 = new System.Windows.Forms.TabPage();
            AdminQLTKRolecb = new System.Windows.Forms.ComboBox();
            AdminQLTKPhonetbx = new System.Windows.Forms.TextBox();
            AdminQLTKFullNametbx = new System.Windows.Forms.TextBox();
            AdminQLTKEmailtbx = new System.Windows.Forms.TextBox();
            AdminQLTKPasstbx = new System.Windows.Forms.TextBox();
            AdminQLTKUserNametbx = new System.Windows.Forms.TextBox();
            AdminQLTKAddbtn = new System.Windows.Forms.Button();
            AdminQLTKDeletebtn = new System.Windows.Forms.Button();
            AdminQLTKUpdatebtn = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            AdminQLTKdata = new System.Windows.Forms.DataGridView();
            AdminQLDV = new System.Windows.Forms.TabPage();
            AdminQbtnLDVRabtn = new System.Windows.Forms.Button();
            AdminQLDVdata = new System.Windows.Forms.DataGridView();
            AdminQLDVAddButton = new System.Windows.Forms.Button();
            AdminQLDVDelbtn = new System.Windows.Forms.Button();
            AdminQLDVbtn = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            AdminQLDVPricetbx = new System.Windows.Forms.TextBox();
            AdminQLDVNameTb = new System.Windows.Forms.TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            AdminBCTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminBCTCdgv).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminQLTKdata).BeginInit();
            AdminQLDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminQLDVdata).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(AdminBCTC);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(AdminQLDV);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(877, 698);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(AdminMainDXbtn);
            tabPage1.Controls.Add(monthCalendar1);
            tabPage1.Controls.Add(AdminIDtb);
            tabPage1.Controls.Add(AdminNametb);
            tabPage1.Controls.Add(AdminMainIDlbl);
            tabPage1.Controls.Add(AdminMainNamelbl);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(869, 665);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminMainDXbtn
            // 
            AdminMainDXbtn.Location = new System.Drawing.Point(43, 622);
            AdminMainDXbtn.Name = "AdminMainDXbtn";
            AdminMainDXbtn.Size = new System.Drawing.Size(94, 29);
            AdminMainDXbtn.TabIndex = 5;
            AdminMainDXbtn.Text = "Đăng xuất";
            AdminMainDXbtn.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new System.Drawing.Point(593, 444);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // AdminIDtb
            // 
            AdminIDtb.Location = new System.Drawing.Point(104, 46);
            AdminIDtb.Name = "AdminIDtb";
            AdminIDtb.Size = new System.Drawing.Size(273, 27);
            AdminIDtb.TabIndex = 3;
            // 
            // AdminNametb
            // 
            AdminNametb.Location = new System.Drawing.Point(104, 89);
            AdminNametb.Name = "AdminNametb";
            AdminNametb.Size = new System.Drawing.Size(273, 27);
            AdminNametb.TabIndex = 2;
            // 
            // AdminMainIDlbl
            // 
            AdminMainIDlbl.AutoSize = true;
            AdminMainIDlbl.Location = new System.Drawing.Point(43, 53);
            AdminMainIDlbl.Name = "AdminMainIDlbl";
            AdminMainIDlbl.Size = new System.Drawing.Size(24, 20);
            AdminMainIDlbl.TabIndex = 1;
            AdminMainIDlbl.Text = "ID";
            // 
            // AdminMainNamelbl
            // 
            AdminMainNamelbl.AutoSize = true;
            AdminMainNamelbl.Location = new System.Drawing.Point(43, 96);
            AdminMainNamelbl.Name = "AdminMainNamelbl";
            AdminMainNamelbl.Size = new System.Drawing.Size(49, 20);
            AdminMainNamelbl.TabIndex = 0;
            AdminMainNamelbl.Text = "Name";
            // 
            // AdminBCTC
            // 
            AdminBCTC.Controls.Add(AdminBCTCRevtbx);
            AdminBCTC.Controls.Add(label10);
            AdminBCTC.Controls.Add(AdminBCTCXuatbtn);
            AdminBCTC.Controls.Add(label1);
            AdminBCTC.Controls.Add(AdminBCTCFromlbl);
            AdminBCTC.Controls.Add(AdminBCTCFToTP);
            AdminBCTC.Controls.Add(AdminBCTCFromTP);
            AdminBCTC.Controls.Add(AdminBCTCdgv);
            AdminBCTC.Location = new System.Drawing.Point(4, 29);
            AdminBCTC.Name = "AdminBCTC";
            AdminBCTC.Padding = new System.Windows.Forms.Padding(3);
            AdminBCTC.Size = new System.Drawing.Size(869, 665);
            AdminBCTC.TabIndex = 1;
            AdminBCTC.Text = "BCTC";
            AdminBCTC.UseVisualStyleBackColor = true;
            // 
            // AdminBCTCRevtbx
            // 
            AdminBCTCRevtbx.Location = new System.Drawing.Point(688, 20);
            AdminBCTCRevtbx.Name = "AdminBCTCRevtbx";
            AdminBCTCRevtbx.Size = new System.Drawing.Size(155, 27);
            AdminBCTCRevtbx.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(563, 27);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(119, 20);
            label10.TabIndex = 9;
            label10.Text = "Tổng Doanh Thu";
            // 
            // AdminBCTCXuatbtn
            // 
            AdminBCTCXuatbtn.Location = new System.Drawing.Point(731, 71);
            AdminBCTCXuatbtn.Name = "AdminBCTCXuatbtn";
            AdminBCTCXuatbtn.Size = new System.Drawing.Size(112, 29);
            AdminBCTCXuatbtn.TabIndex = 8;
            AdminBCTCXuatbtn.Text = "Tính tổng";
            AdminBCTCXuatbtn.UseVisualStyleBackColor = true;
            AdminBCTCXuatbtn.Click += AdminBCTCXuatbtn_ClickAsync;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(28, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 23);
            label1.TabIndex = 7;
            label1.Text = "Đến ngày";
            // 
            // AdminBCTCFromlbl
            // 
            AdminBCTCFromlbl.AutoSize = true;
            AdminBCTCFromlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AdminBCTCFromlbl.Location = new System.Drawing.Point(28, 31);
            AdminBCTCFromlbl.Name = "AdminBCTCFromlbl";
            AdminBCTCFromlbl.Size = new System.Drawing.Size(75, 23);
            AdminBCTCFromlbl.TabIndex = 6;
            AdminBCTCFromlbl.Text = "Từ ngày";
            // 
            // AdminBCTCFToTP
            // 
            AdminBCTCFToTP.Location = new System.Drawing.Point(129, 67);
            AdminBCTCFToTP.Name = "AdminBCTCFToTP";
            AdminBCTCFToTP.Size = new System.Drawing.Size(250, 27);
            AdminBCTCFToTP.TabIndex = 5;
            AdminBCTCFToTP.ValueChanged += AdminBCTCFToTP_ValueChanged;
            // 
            // AdminBCTCFromTP
            // 
            AdminBCTCFromTP.Location = new System.Drawing.Point(129, 27);
            AdminBCTCFromTP.Name = "AdminBCTCFromTP";
            AdminBCTCFromTP.Size = new System.Drawing.Size(250, 27);
            AdminBCTCFromTP.TabIndex = 4;
            AdminBCTCFromTP.ValueChanged += AdminBCTCFromTP_ValueChanged;
            // 
            // AdminBCTCdgv
            // 
            AdminBCTCdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminBCTCdgv.Location = new System.Drawing.Point(8, 125);
            AdminBCTCdgv.Name = "AdminBCTCdgv";
            AdminBCTCdgv.RowHeadersWidth = 51;
            AdminBCTCdgv.Size = new System.Drawing.Size(853, 532);
            AdminBCTCdgv.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AdminQLTKRolecb);
            tabPage2.Controls.Add(AdminQLTKPhonetbx);
            tabPage2.Controls.Add(AdminQLTKFullNametbx);
            tabPage2.Controls.Add(AdminQLTKEmailtbx);
            tabPage2.Controls.Add(AdminQLTKPasstbx);
            tabPage2.Controls.Add(AdminQLTKUserNametbx);
            tabPage2.Controls.Add(AdminQLTKAddbtn);
            tabPage2.Controls.Add(AdminQLTKDeletebtn);
            tabPage2.Controls.Add(AdminQLTKUpdatebtn);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(AdminQLTKdata);
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(869, 665);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "QLTK";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // AdminQLTKRolecb
            // 
            AdminQLTKRolecb.FormattingEnabled = true;
            AdminQLTKRolecb.Items.AddRange(new object[] { "Doctor", "Receptionist", "Admin", "Null" });
            AdminQLTKRolecb.Location = new System.Drawing.Point(469, 82);
            AdminQLTKRolecb.Name = "AdminQLTKRolecb";
            AdminQLTKRolecb.Size = new System.Drawing.Size(239, 28);
            AdminQLTKRolecb.TabIndex = 16;
            // 
            // AdminQLTKPhonetbx
            // 
            AdminQLTKPhonetbx.Location = new System.Drawing.Point(469, 46);
            AdminQLTKPhonetbx.Name = "AdminQLTKPhonetbx";
            AdminQLTKPhonetbx.Size = new System.Drawing.Size(239, 27);
            AdminQLTKPhonetbx.TabIndex = 15;
            // 
            // AdminQLTKFullNametbx
            // 
            AdminQLTKFullNametbx.Location = new System.Drawing.Point(469, 15);
            AdminQLTKFullNametbx.Name = "AdminQLTKFullNametbx";
            AdminQLTKFullNametbx.Size = new System.Drawing.Size(239, 27);
            AdminQLTKFullNametbx.TabIndex = 14;
            // 
            // AdminQLTKEmailtbx
            // 
            AdminQLTKEmailtbx.Location = new System.Drawing.Point(109, 82);
            AdminQLTKEmailtbx.Name = "AdminQLTKEmailtbx";
            AdminQLTKEmailtbx.Size = new System.Drawing.Size(239, 27);
            AdminQLTKEmailtbx.TabIndex = 13;
            // 
            // AdminQLTKPasstbx
            // 
            AdminQLTKPasstbx.Location = new System.Drawing.Point(109, 46);
            AdminQLTKPasstbx.Name = "AdminQLTKPasstbx";
            AdminQLTKPasstbx.Size = new System.Drawing.Size(239, 27);
            AdminQLTKPasstbx.TabIndex = 12;
            // 
            // AdminQLTKUserNametbx
            // 
            AdminQLTKUserNametbx.Location = new System.Drawing.Point(109, 15);
            AdminQLTKUserNametbx.Name = "AdminQLTKUserNametbx";
            AdminQLTKUserNametbx.Size = new System.Drawing.Size(239, 27);
            AdminQLTKUserNametbx.TabIndex = 11;
            // 
            // AdminQLTKAddbtn
            // 
            AdminQLTKAddbtn.Location = new System.Drawing.Point(767, 9);
            AdminQLTKAddbtn.Name = "AdminQLTKAddbtn";
            AdminQLTKAddbtn.Size = new System.Drawing.Size(94, 29);
            AdminQLTKAddbtn.TabIndex = 10;
            AdminQLTKAddbtn.Text = "Thêm";
            AdminQLTKAddbtn.UseVisualStyleBackColor = true;
            AdminQLTKAddbtn.Click += AdminQLTKAddbtn_Click;
            // 
            // AdminQLTKDeletebtn
            // 
            AdminQLTKDeletebtn.Location = new System.Drawing.Point(767, 90);
            AdminQLTKDeletebtn.Name = "AdminQLTKDeletebtn";
            AdminQLTKDeletebtn.Size = new System.Drawing.Size(94, 29);
            AdminQLTKDeletebtn.TabIndex = 9;
            AdminQLTKDeletebtn.Text = "Xóa";
            AdminQLTKDeletebtn.UseVisualStyleBackColor = true;
            AdminQLTKDeletebtn.Click += AdminQLTKDeletebtn_Click;
            // 
            // AdminQLTKUpdatebtn
            // 
            AdminQLTKUpdatebtn.Location = new System.Drawing.Point(767, 49);
            AdminQLTKUpdatebtn.Name = "AdminQLTKUpdatebtn";
            AdminQLTKUpdatebtn.Size = new System.Drawing.Size(94, 29);
            AdminQLTKUpdatebtn.TabIndex = 8;
            AdminQLTKUpdatebtn.Text = "Cập nhật";
            AdminQLTKUpdatebtn.UseVisualStyleBackColor = true;
            AdminQLTKUpdatebtn.Click += AdminQLTKUpdatebtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(378, 49);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(378, 18);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 20);
            label6.TabIndex = 6;
            label6.Text = "FullName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(25, 82);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(378, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Role";
            // 
            // AdminQLTKdata
            // 
            AdminQLTKdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminQLTKdata.Location = new System.Drawing.Point(8, 125);
            AdminQLTKdata.Name = "AdminQLTKdata";
            AdminQLTKdata.RowHeadersWidth = 51;
            AdminQLTKdata.Size = new System.Drawing.Size(853, 532);
            AdminQLTKdata.TabIndex = 0;
            AdminQLTKdata.CellContentClick += AdminQLTKdata_CellContentClick;
            // 
            // AdminQLDV
            // 
            AdminQLDV.Controls.Add(AdminQbtnLDVRabtn);
            AdminQLDV.Controls.Add(AdminQLDVdata);
            AdminQLDV.Controls.Add(AdminQLDVAddButton);
            AdminQLDV.Controls.Add(AdminQLDVDelbtn);
            AdminQLDV.Controls.Add(AdminQLDVbtn);
            AdminQLDV.Controls.Add(label8);
            AdminQLDV.Controls.Add(label9);
            AdminQLDV.Controls.Add(AdminQLDVPricetbx);
            AdminQLDV.Controls.Add(AdminQLDVNameTb);
            AdminQLDV.Location = new System.Drawing.Point(4, 29);
            AdminQLDV.Name = "AdminQLDV";
            AdminQLDV.Padding = new System.Windows.Forms.Padding(3);
            AdminQLDV.Size = new System.Drawing.Size(869, 665);
            AdminQLDV.TabIndex = 3;
            AdminQLDV.Text = "QLDV";
            AdminQLDV.UseVisualStyleBackColor = true;
            AdminQLDV.Click += AdminQLDV_Click;
            // 
            // AdminQbtnLDVRabtn
            // 
            AdminQbtnLDVRabtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AdminQbtnLDVRabtn.Location = new System.Drawing.Point(686, 81);
            AdminQbtnLDVRabtn.Name = "AdminQbtnLDVRabtn";
            AdminQbtnLDVRabtn.Size = new System.Drawing.Size(94, 29);
            AdminQbtnLDVRabtn.TabIndex = 16;
            AdminQbtnLDVRabtn.Text = "Sắp xếp";
            AdminQbtnLDVRabtn.UseVisualStyleBackColor = true;
            AdminQbtnLDVRabtn.Click += AdminQbtnLDVRabtn_Click;
            // 
            // AdminQLDVdata
            // 
            AdminQLDVdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminQLDVdata.Location = new System.Drawing.Point(6, 127);
            AdminQLDVdata.Name = "AdminQLDVdata";
            AdminQLDVdata.RowHeadersWidth = 51;
            AdminQLDVdata.Size = new System.Drawing.Size(853, 532);
            AdminQLDVdata.TabIndex = 15;
            AdminQLDVdata.CellContentClick += AdminQLDVdata_CellContentClick;
            // 
            // AdminQLDVAddButton
            // 
            AdminQLDVAddButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AdminQLDVAddButton.Location = new System.Drawing.Point(558, 21);
            AdminQLDVAddButton.Name = "AdminQLDVAddButton";
            AdminQLDVAddButton.Size = new System.Drawing.Size(94, 29);
            AdminQLDVAddButton.TabIndex = 14;
            AdminQLDVAddButton.Text = "Thêm";
            AdminQLDVAddButton.UseVisualStyleBackColor = true;
            AdminQLDVAddButton.Click += AdminQLDVAddButton_Click;
            // 
            // AdminQLDVDelbtn
            // 
            AdminQLDVDelbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AdminQLDVDelbtn.Location = new System.Drawing.Point(558, 81);
            AdminQLDVDelbtn.Name = "AdminQLDVDelbtn";
            AdminQLDVDelbtn.Size = new System.Drawing.Size(94, 29);
            AdminQLDVDelbtn.TabIndex = 13;
            AdminQLDVDelbtn.Text = "Xóa";
            AdminQLDVDelbtn.UseVisualStyleBackColor = true;
            AdminQLDVDelbtn.Click += AdminQLDVDelbtn_Click;
            // 
            // AdminQLDVbtn
            // 
            AdminQLDVbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AdminQLDVbtn.Location = new System.Drawing.Point(686, 21);
            AdminQLDVbtn.Name = "AdminQLDVbtn";
            AdminQLDVbtn.Size = new System.Drawing.Size(94, 29);
            AdminQLDVbtn.TabIndex = 12;
            AdminQLDVbtn.Text = "Sửa giá";
            AdminQLDVbtn.UseVisualStyleBackColor = true;
            AdminQLDVbtn.Click += AdminQLDVbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            label8.Location = new System.Drawing.Point(30, 81);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(101, 23);
            label8.TabIndex = 11;
            label8.Text = "Giá Dịch vụ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            label9.Location = new System.Drawing.Point(28, 21);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(102, 23);
            label9.TabIndex = 10;
            label9.Text = "Tên Dịch vụ";
            // 
            // AdminQLDVPricetbx
            // 
            AdminQLDVPricetbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AdminQLDVPricetbx.Location = new System.Drawing.Point(142, 77);
            AdminQLDVPricetbx.Name = "AdminQLDVPricetbx";
            AdminQLDVPricetbx.Size = new System.Drawing.Size(327, 29);
            AdminQLDVPricetbx.TabIndex = 9;
            // 
            // AdminQLDVNameTb
            // 
            AdminQLDVNameTb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AdminQLDVNameTb.Location = new System.Drawing.Point(142, 17);
            AdminQLDVNameTb.Name = "AdminQLDVNameTb";
            AdminQLDVNameTb.Size = new System.Drawing.Size(327, 29);
            AdminQLDVNameTb.TabIndex = 8;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(877, 698);
            Controls.Add(tabControl1);
            Name = "AdminMain";
            Text = "AdminMain";
            FormClosing += AdminMain_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            AdminBCTC.ResumeLayout(false);
            AdminBCTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminBCTCdgv).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminQLTKdata).EndInit();
            AdminQLDV.ResumeLayout(false);
            AdminQLDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminQLDVdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label AdminMainNamelbl;
        private System.Windows.Forms.TabPage AdminBCTC;
        private System.Windows.Forms.Label AdminMainIDlbl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox AdminIDtb;
        private System.Windows.Forms.TextBox AdminNametb;
        private System.Windows.Forms.Button AdminMainDXbtn;
        private System.Windows.Forms.DataGridView AdminBCTCdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdminBCTCFromlbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AdminBCTCXuatbtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView AdminQLTKdata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AdminQLTKDeletebtn;
        private System.Windows.Forms.Button AdminQLTKUpdatebtn;
        private System.Windows.Forms.TabPage AdminQLDV;
        private System.Windows.Forms.Button AdminQLDVDelbtn;
        private System.Windows.Forms.Button AdminQLDVbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AdminQLDVPricetbx;
        private System.Windows.Forms.TextBox AdminQLDVNameTb;
        private System.Windows.Forms.DataGridView AdminQLDVdata;
        private System.Windows.Forms.Button AdminQLDVAddButton;
        private System.Windows.Forms.Button AdminQLTKAddbtn;
        private System.Windows.Forms.TextBox AdminQLTKPhonetbx;
        private System.Windows.Forms.TextBox AdminQLTKFullNametbx;
        private System.Windows.Forms.TextBox AdminQLTKEmailtbx;
        private System.Windows.Forms.TextBox AdminQLTKPasstbx;
        private System.Windows.Forms.TextBox AdminQLTKUserNametbx;
        private System.Windows.Forms.ComboBox AdminQLTKRolecb;
        private System.Windows.Forms.Button AdminQbtnLDVRabtn;
        private System.Windows.Forms.DateTimePicker AdminBCTCFromTP;
        private System.Windows.Forms.DateTimePicker AdminBCTCFToTP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AdminBCTCRevtbx;
    }
}