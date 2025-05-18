using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Doctor : User
    {
        private User currentUser;
        public string Qualification { get; set; }
        public ICollection<Appointment> Appointments { get; set; } = [];

        public Doctor(string userName, string password, string email, string qualification)
            : base(userName, password, email, UserRole.Doctor)
        {
            this.Qualification = qualification;
        }
    }
}