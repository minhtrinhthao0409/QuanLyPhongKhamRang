using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Receptionist : User
    {
        public Receptionist(string userName, string password, string email) : base(userName, password, email)
        {
        }
    }
}
