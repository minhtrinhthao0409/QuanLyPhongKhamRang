using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Doctor : User
    {
        private string qualification;

        public string Qualification { get => qualification; set => qualification = value; }

        public Doctor(string userName, string password, string email, string qualification) : base(userName, password, email)
        {
            this.Qualification = qualification;
        }

        
    }
}
