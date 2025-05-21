namespace QuanlyPhongKham.Views.Receptionist
{
    partial class PatientFrm
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
            panel2 = new System.Windows.Forms.Panel();
            Homelbl = new System.Windows.Forms.Label();
            Invoicelbl = new System.Windows.Forms.Label();
            Patientlbl = new System.Windows.Forms.Label();
            Schedulelbl = new System.Windows.Forms.Label();
            Appointmentlbl = new System.Windows.Forms.Label();
            SignOutlbl = new System.Windows.Forms.Label();
            PatientTab = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            CrudPanel = new System.Windows.Forms.Panel();
            ResetSearchPatientbtn = new System.Windows.Forms.Button();
            patientEmailTxt = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            PatientPhoneNoTxt = new System.Windows.Forms.TextBox();
            PatientPhoneNolbl = new System.Windows.Forms.Label();
            PatientNameTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CrudPatient = new System.Windows.Forms.Label();
            SearchPatientBtn = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            panel1 = new System.Windows.Forms.Panel();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            Doblbl = new System.Windows.Forms.Label();
            Guardian = new System.Windows.Forms.TextBox();
            Guardianlbl = new System.Windows.Forms.Label();
            listBox2 = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            PatientEmail = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            PatientPhoneNo = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            PatientName = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ResetBtn = new System.Windows.Forms.Button();
            UpdatePatientBtn = new System.Windows.Forms.Button();
            AddPatientbtn = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            PatientTab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CrudPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(Homelbl);
            panel2.Controls.Add(Invoicelbl);
            panel2.Controls.Add(Patientlbl);
            panel2.Controls.Add(Schedulelbl);
            panel2.Controls.Add(Appointmentlbl);
            panel2.Controls.Add(SignOutlbl);
            panel2.Location = new System.Drawing.Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(176, 638);
            panel2.TabIndex = 6;
            // 
            // Homelbl
            // 
            Homelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Homelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Homelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Homelbl.Location = new System.Drawing.Point(3, 206);
            Homelbl.Name = "Homelbl";
            Homelbl.Size = new System.Drawing.Size(170, 46);
            Homelbl.TabIndex = 7;
            Homelbl.Text = "Home";
            Homelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Homelbl.Click += menulbl_click;
            // 
            // Invoicelbl
            // 
            Invoicelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Invoicelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Invoicelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Invoicelbl.Location = new System.Drawing.Point(3, 390);
            Invoicelbl.Name = "Invoicelbl";
            Invoicelbl.Size = new System.Drawing.Size(170, 46);
            Invoicelbl.TabIndex = 6;
            Invoicelbl.Text = "Invoice";
            Invoicelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Invoicelbl.Click += menulbl_click;
            // 
            // Patientlbl
            // 
            Patientlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Patientlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Patientlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Patientlbl.Location = new System.Drawing.Point(3, 344);
            Patientlbl.Name = "Patientlbl";
            Patientlbl.Size = new System.Drawing.Size(170, 46);
            Patientlbl.TabIndex = 5;
            Patientlbl.Text = "Patient";
            Patientlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Patientlbl.Click += menulbl_click;
            // 
            // Schedulelbl
            // 
            Schedulelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Schedulelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Schedulelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Schedulelbl.Location = new System.Drawing.Point(3, 298);
            Schedulelbl.Name = "Schedulelbl";
            Schedulelbl.Size = new System.Drawing.Size(170, 46);
            Schedulelbl.TabIndex = 5;
            Schedulelbl.Text = "Schedule";
            Schedulelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Schedulelbl.Click += menulbl_click;
            // 
            // Appointmentlbl
            // 
            Appointmentlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            Appointmentlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Appointmentlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            Appointmentlbl.Location = new System.Drawing.Point(3, 252);
            Appointmentlbl.Name = "Appointmentlbl";
            Appointmentlbl.Size = new System.Drawing.Size(170, 46);
            Appointmentlbl.TabIndex = 5;
            Appointmentlbl.Text = "Appointment";
            Appointmentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Appointmentlbl.Click += menulbl_click;
            // 
            // SignOutlbl
            // 
            SignOutlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            SignOutlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SignOutlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            SignOutlbl.Location = new System.Drawing.Point(3, 582);
            SignOutlbl.Name = "SignOutlbl";
            SignOutlbl.Size = new System.Drawing.Size(170, 46);
            SignOutlbl.TabIndex = 4;
            SignOutlbl.Text = "Sign Out";
            SignOutlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientTab
            // 
            PatientTab.Controls.Add(tabPage1);
            PatientTab.Controls.Add(tabPage2);
            PatientTab.Location = new System.Drawing.Point(194, 4);
            PatientTab.Name = "PatientTab";
            PatientTab.SelectedIndex = 0;
            PatientTab.Size = new System.Drawing.Size(807, 665);
            PatientTab.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(CrudPanel);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(799, 637);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Search Patient";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(2, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(795, 400);
            dataGridView1.TabIndex = 8;
            // 
            // CrudPanel
            // 
            CrudPanel.Controls.Add(ResetSearchPatientbtn);
            CrudPanel.Controls.Add(patientEmailTxt);
            CrudPanel.Controls.Add(label2);
            CrudPanel.Controls.Add(PatientPhoneNoTxt);
            CrudPanel.Controls.Add(PatientPhoneNolbl);
            CrudPanel.Controls.Add(PatientNameTxt);
            CrudPanel.Controls.Add(label1);
            CrudPanel.Controls.Add(CrudPatient);
            CrudPanel.Controls.Add(SearchPatientBtn);
            CrudPanel.Location = new System.Drawing.Point(6, 6);
            CrudPanel.Name = "CrudPanel";
            CrudPanel.Size = new System.Drawing.Size(796, 225);
            CrudPanel.TabIndex = 7;
            // 
            // ResetSearchPatientbtn
            // 
            ResetSearchPatientbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            ResetSearchPatientbtn.Location = new System.Drawing.Point(398, 148);
            ResetSearchPatientbtn.Name = "ResetSearchPatientbtn";
            ResetSearchPatientbtn.Size = new System.Drawing.Size(93, 50);
            ResetSearchPatientbtn.TabIndex = 23;
            ResetSearchPatientbtn.Text = "Reset";
            ResetSearchPatientbtn.UseVisualStyleBackColor = true;
            // 
            // patientEmailTxt
            // 
            patientEmailTxt.Location = new System.Drawing.Point(521, 96);
            patientEmailTxt.Name = "patientEmailTxt";
            patientEmailTxt.Size = new System.Drawing.Size(211, 23);
            patientEmailTxt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(438, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 17);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // PatientPhoneNoTxt
            // 
            PatientPhoneNoTxt.Location = new System.Drawing.Point(143, 95);
            PatientPhoneNoTxt.Name = "PatientPhoneNoTxt";
            PatientPhoneNoTxt.Size = new System.Drawing.Size(211, 23);
            PatientPhoneNoTxt.TabIndex = 18;
            // 
            // PatientPhoneNolbl
            // 
            PatientPhoneNolbl.AutoSize = true;
            PatientPhoneNolbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PatientPhoneNolbl.Location = new System.Drawing.Point(24, 96);
            PatientPhoneNolbl.Name = "PatientPhoneNolbl";
            PatientPhoneNolbl.Size = new System.Drawing.Size(101, 17);
            PatientPhoneNolbl.TabIndex = 17;
            PatientPhoneNolbl.Text = "Phone Number";
            // 
            // PatientNameTxt
            // 
            PatientNameTxt.Location = new System.Drawing.Point(143, 48);
            PatientNameTxt.Name = "PatientNameTxt";
            PatientNameTxt.Size = new System.Drawing.Size(589, 23);
            PatientNameTxt.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(20, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 17);
            label1.TabIndex = 15;
            label1.Text = "Patient Name";
            // 
            // CrudPatient
            // 
            CrudPatient.AutoSize = true;
            CrudPatient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            CrudPatient.Location = new System.Drawing.Point(269, 10);
            CrudPatient.Name = "CrudPatient";
            CrudPatient.Size = new System.Drawing.Size(244, 25);
            CrudPatient.TabIndex = 15;
            CrudPatient.Text = "Search Patient Infomation";
            // 
            // SearchPatientBtn
            // 
            SearchPatientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            SearchPatientBtn.Location = new System.Drawing.Point(261, 148);
            SearchPatientBtn.Name = "SearchPatientBtn";
            SearchPatientBtn.Size = new System.Drawing.Size(93, 50);
            SearchPatientBtn.TabIndex = 5;
            SearchPatientBtn.Text = "Search";
            SearchPatientBtn.UseVisualStyleBackColor = true;
            SearchPatientBtn.Click += SearchPatientBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(799, 637);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Patient";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(4, 304);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(795, 331);
            dataGridView2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(Doblbl);
            panel1.Controls.Add(Guardian);
            panel1.Controls.Add(Guardianlbl);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PatientEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(PatientPhoneNo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PatientName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(ResetBtn);
            panel1.Controls.Add(UpdatePatientBtn);
            panel1.Controls.Add(AddPatientbtn);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(796, 296);
            panel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(143, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(211, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // Doblbl
            // 
            Doblbl.AutoSize = true;
            Doblbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Doblbl.Location = new System.Drawing.Point(20, 92);
            Doblbl.Name = "Doblbl";
            Doblbl.Size = new System.Drawing.Size(36, 17);
            Doblbl.TabIndex = 25;
            Doblbl.Text = "DOB";
            // 
            // Guardian
            // 
            Guardian.Location = new System.Drawing.Point(143, 162);
            Guardian.Name = "Guardian";
            Guardian.Size = new System.Drawing.Size(211, 23);
            Guardian.TabIndex = 24;
            // 
            // Guardianlbl
            // 
            Guardianlbl.AutoSize = true;
            Guardianlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Guardianlbl.Location = new System.Drawing.Point(24, 163);
            Guardianlbl.Name = "Guardianlbl";
            Guardianlbl.Size = new System.Drawing.Size(64, 17);
            Guardianlbl.TabIndex = 23;
            Guardianlbl.Text = "Guardian";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Male", "Female" });
            listBox2.Location = new System.Drawing.Point(466, 92);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(54, 19);
            listBox2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(397, 92);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 17);
            label3.TabIndex = 21;
            label3.Text = "Gender";
            // 
            // PatientEmail
            // 
            PatientEmail.Location = new System.Drawing.Point(466, 130);
            PatientEmail.Name = "PatientEmail";
            PatientEmail.Size = new System.Drawing.Size(268, 23);
            PatientEmail.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(397, 135);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 17);
            label4.TabIndex = 19;
            label4.Text = "Email";
            // 
            // PatientPhoneNo
            // 
            PatientPhoneNo.Location = new System.Drawing.Point(143, 129);
            PatientPhoneNo.Name = "PatientPhoneNo";
            PatientPhoneNo.Size = new System.Drawing.Size(211, 23);
            PatientPhoneNo.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(20, 130);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 17);
            label5.TabIndex = 17;
            label5.Text = "Phone Number";
            // 
            // PatientName
            // 
            PatientName.Location = new System.Drawing.Point(143, 48);
            PatientName.Name = "PatientName";
            PatientName.Size = new System.Drawing.Size(591, 23);
            PatientName.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(20, 50);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 17);
            label6.TabIndex = 15;
            label6.Text = "Patient Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(269, 11);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(222, 25);
            label7.TabIndex = 15;
            label7.Text = "Add Patient Infomation";
            // 
            // ResetBtn
            // 
            ResetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            ResetBtn.Location = new System.Drawing.Point(521, 215);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new System.Drawing.Size(93, 50);
            ResetBtn.TabIndex = 7;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            // 
            // UpdatePatientBtn
            // 
            UpdatePatientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            UpdatePatientBtn.Location = new System.Drawing.Point(346, 215);
            UpdatePatientBtn.Name = "UpdatePatientBtn";
            UpdatePatientBtn.Size = new System.Drawing.Size(93, 50);
            UpdatePatientBtn.TabIndex = 6;
            UpdatePatientBtn.Text = "Update";
            UpdatePatientBtn.UseVisualStyleBackColor = true;
            // 
            // AddPatientbtn
            // 
            AddPatientbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            AddPatientbtn.Location = new System.Drawing.Point(155, 215);
            AddPatientbtn.Name = "AddPatientbtn";
            AddPatientbtn.Size = new System.Drawing.Size(93, 50);
            AddPatientbtn.TabIndex = 5;
            AddPatientbtn.Text = "Add";
            AddPatientbtn.UseVisualStyleBackColor = true;
            AddPatientbtn.Click += AddPatientbtn_Click;
            // 
            // PatientFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(PatientTab);
            Controls.Add(panel2);
            Name = "PatientFrm";
            Text = "PatientForm";
            panel2.ResumeLayout(false);
            PatientTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CrudPanel.ResumeLayout(false);
            CrudPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Label Invoicelbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Schedulelbl;
        private System.Windows.Forms.Label Appointmentlbl;
        private System.Windows.Forms.Label SignOutlbl;
        private System.Windows.Forms.TabControl PatientTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel CrudPanel;
        private System.Windows.Forms.Button ResetSearchPatientbtn;
        private System.Windows.Forms.TextBox patientEmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatientPhoneNoTxt;
        private System.Windows.Forms.Label PatientPhoneNolbl;
        private System.Windows.Forms.TextBox PatientNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CrudPatient;
        private System.Windows.Forms.Button SearchPatientBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Doblbl;
        private System.Windows.Forms.TextBox Guardian;
        private System.Windows.Forms.Label Guardianlbl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatientEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatientPhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button UpdatePatientBtn;
        private System.Windows.Forms.Button AddPatientbtn;
    }
}