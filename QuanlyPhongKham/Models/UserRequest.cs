using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class UserRequest
    {
        public UserRequest(string userName, string password, string email, UserRole role)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Role = role;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }

    }
}
