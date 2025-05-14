using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class User
    {
        public User(string userName, string password, string email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        string userName { get; set; }
        string password { get; set; }
        string email {  get; set; }
        string 

    }
}
