namespace QuanlyPhongKham.Views.Receptionist
{
    partial class ReceptionistMainFrm
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
            UpcomingAppointmentView = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            Editbtn = new System.Windows.Forms.Button();
            Usernamelbl = new System.Windows.Forms.Label();
            Emaillbl = new System.Windows.Forms.Label();
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            Welcomelbl = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpcomingAppointmentView).BeginInit();
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
            panel2.TabIndex = 5;
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
            // UpcomingAppointmentView
            // 
            UpcomingAppointmentView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            UpcomingAppointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpcomingAppointmentView.Location = new System.Drawing.Point(250, 301);
            UpcomingAppointmentView.Name = "UpcomingAppointmentView";
            UpcomingAppointmentView.Size = new System.Drawing.Size(675, 357);
            UpcomingAppointmentView.TabIndex = 18;
            UpcomingAppointmentView.CellContentClick += UpcomingAppointmentView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(208, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(291, 32);
            label1.TabIndex = 17;
            label1.Text = "Upcoming Appointment";
            // 
            // Editbtn
            // 
            Editbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Editbtn.Location = new System.Drawing.Point(638, 154);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new System.Drawing.Size(72, 39);
            Editbtn.TabIndex = 16;
            Editbtn.Text = "Edit";
            Editbtn.UseVisualStyleBackColor = true;
            // 
            // Usernamelbl
            // 
            Usernamelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Usernamelbl.Location = new System.Drawing.Point(208, 74);
            Usernamelbl.Name = "Usernamelbl";
            Usernamelbl.Size = new System.Drawing.Size(502, 25);
            Usernamelbl.TabIndex = 15;
            Usernamelbl.Text = "Username:";
            // 
            // Emaillbl
            // 
            Emaillbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Emaillbl.Location = new System.Drawing.Point(208, 112);
            Emaillbl.Name = "Emaillbl";
            Emaillbl.Size = new System.Drawing.Size(502, 25);
            Emaillbl.TabIndex = 14;
            Emaillbl.Text = "Email:";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new System.Drawing.Point(763, 31);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 13;
            // 
            // Welcomelbl
            // 
            Welcomelbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Welcomelbl.Location = new System.Drawing.Point(208, 31);
            Welcomelbl.Name = "Welcomelbl";
            Welcomelbl.Size = new System.Drawing.Size(397, 43);
            Welcomelbl.TabIndex = 12;
            Welcomelbl.Text = "Welcome,";
            // 
            // ReceptionistMainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 681);
            Controls.Add(UpcomingAppointmentView);
            Controls.Add(label1);
            Controls.Add(Editbtn);
            Controls.Add(Usernamelbl);
            Controls.Add(Emaillbl);
            Controls.Add(monthCalendar1);
            Controls.Add(Welcomelbl);
            Controls.Add(panel2);
            Name = "ReceptionistMainFrm";
            Text = "ReceptionistMainFrm";
            Load += ReceptionistMainFrm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UpcomingAppointmentView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Label Invoicelbl;
        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.Label Schedulelbl;
        private System.Windows.Forms.Label Appointmentlbl;
        private System.Windows.Forms.Label SignOutlbl;
        private System.Windows.Forms.DataGridView UpcomingAppointmentView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label Welcomelbl;
    }
}