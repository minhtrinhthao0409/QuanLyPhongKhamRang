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
    public partial class AppointmentFrm : LeftSideMenu
    {
        private User user;
        private Form currentForm = null;
        private readonly AppointmentRepository _appointmentRepo = new AppointmentRepository();

        public AppointmentFrm(User user)
        {
            InitializeComponent();
            this.user = user;

        }
    }
}
