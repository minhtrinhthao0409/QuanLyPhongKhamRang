using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using QuanlyPhongKham.Views.Receptionist;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuanlyPhongKham.Views
{
    public partial class ReceptionistMain : LeftSideMenu
    {
        private User user;
        private Form currentForm = null;
        
        private readonly AppointmentRepository _appointmentRepo = new();
        private readonly UserRepository _userRepo = new();


        public ReceptionistMain(User user)
        {
            InitializeComponent();
            this.user = user;

            Welcomelbl.Text = $"Welcome, {user.FullName}";
            Usernamelbl.Text = $"Username: {user.UserName}";
            Emaillbl.Text = $"Email: {user.Email}";

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

    }
}
