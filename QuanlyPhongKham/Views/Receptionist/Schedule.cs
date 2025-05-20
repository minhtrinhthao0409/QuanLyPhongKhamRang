using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyPhongKham.Views.Receptionist
{
    public partial class ScheduleFrm : LeftSideMenu
    {
        private User user;
        private Form currentForm = null;
        //private string connectionString = @"QuanLyPhongKham.db";
        private readonly AppointmentRepository _appointmentRepo = new AppointmentRepository();


        public ScheduleFrm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
