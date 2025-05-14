namespace QuanlyPhongKham.Views.Receptionist
{
    partial class PatientInfo
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
            CrudPanel = new System.Windows.Forms.Panel();
            listBox1 = new System.Windows.Forms.ListBox();
            PatientGenderTxt = new System.Windows.Forms.Label();
            patientEmailTxt = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            PatientPhoneNoTxt = new System.Windows.Forms.TextBox();
            PatientPhoneNolbl = new System.Windows.Forms.Label();
            PatientNameTxt = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            CrudPatient = new System.Windows.Forms.Label();
            AddScheduleBtn = new System.Windows.Forms.Button();
            CrudPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new System.Drawing.Point(3, 21);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(176, 638);
            panel2.TabIndex = 7;
            // 
            // CrudPanel
            // 
            CrudPanel.Controls.Add(listBox1);
            CrudPanel.Controls.Add(PatientGenderTxt);
            CrudPanel.Controls.Add(patientEmailTxt);
            CrudPanel.Controls.Add(label2);
            CrudPanel.Controls.Add(PatientPhoneNoTxt);
            CrudPanel.Controls.Add(PatientPhoneNolbl);
            CrudPanel.Controls.Add(PatientNameTxt);
            CrudPanel.Controls.Add(label1);
            CrudPanel.Controls.Add(CrudPatient);
            CrudPanel.Controls.Add(AddScheduleBtn);
            CrudPanel.Location = new System.Drawing.Point(191, 21);
            CrudPanel.Name = "CrudPanel";
            CrudPanel.Size = new System.Drawing.Size(815, 226);
            CrudPanel.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Male", "Female" });
            listBox1.Location = new System.Drawing.Point(521, 46);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(54, 19);
            listBox1.TabIndex = 22;
            // 
            // PatientGenderTxt
            // 
            PatientGenderTxt.AutoSize = true;
            PatientGenderTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PatientGenderTxt.Location = new System.Drawing.Point(439, 48);
            PatientGenderTxt.Name = "PatientGenderTxt";
            PatientGenderTxt.Size = new System.Drawing.Size(52, 17);
            PatientGenderTxt.TabIndex = 21;
            PatientGenderTxt.Text = "Gender";
            // 
            // patientEmailTxt
            // 
            patientEmailTxt.Location = new System.Drawing.Point(521, 91);
            patientEmailTxt.Name = "patientEmailTxt";
            patientEmailTxt.Size = new System.Drawing.Size(211, 23);
            patientEmailTxt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(438, 93);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 17);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // PatientPhoneNoTxt
            // 
            PatientPhoneNoTxt.Location = new System.Drawing.Point(143, 90);
            PatientPhoneNoTxt.Name = "PatientPhoneNoTxt";
            PatientPhoneNoTxt.Size = new System.Drawing.Size(211, 23);
            PatientPhoneNoTxt.TabIndex = 18;
            // 
            // PatientPhoneNolbl
            // 
            PatientPhoneNolbl.AutoSize = true;
            PatientPhoneNolbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PatientPhoneNolbl.Location = new System.Drawing.Point(24, 91);
            PatientPhoneNolbl.Name = "PatientPhoneNolbl";
            PatientPhoneNolbl.Size = new System.Drawing.Size(101, 17);
            PatientPhoneNolbl.TabIndex = 17;
            PatientPhoneNolbl.Text = "Phone Number";
            // 
            // PatientNameTxt
            // 
            PatientNameTxt.Location = new System.Drawing.Point(143, 48);
            PatientNameTxt.Name = "PatientNameTxt";
            PatientNameTxt.Size = new System.Drawing.Size(211, 23);
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
            CrudPatient.Location = new System.Drawing.Point(301, 10);
            CrudPatient.Name = "CrudPatient";
            CrudPatient.Size = new System.Drawing.Size(180, 25);
            CrudPatient.TabIndex = 15;
            CrudPatient.Text = "Patient Infomation";
            // 
            // AddScheduleBtn
            // 
            AddScheduleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            AddScheduleBtn.Location = new System.Drawing.Point(342, 149);
            AddScheduleBtn.Name = "AddScheduleBtn";
            AddScheduleBtn.Size = new System.Drawing.Size(93, 50);
            AddScheduleBtn.TabIndex = 5;
            AddScheduleBtn.Text = "Search";
            AddScheduleBtn.UseVisualStyleBackColor = true;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(panel2);
            Controls.Add(CrudPanel);
            Name = "PatientInfo";
            Text = "PatientInfo";
            CrudPanel.ResumeLayout(false);
            CrudPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel CrudPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label PatientGenderTxt;
        private System.Windows.Forms.TextBox patientEmailTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PatientPhoneNoTxt;
        private System.Windows.Forms.Label PatientPhoneNolbl;
        private System.Windows.Forms.TextBox PatientNameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CrudPatient;
        private System.Windows.Forms.Button AddScheduleBtn;
    }
}