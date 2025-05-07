using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class UserRequest
    {
        public UserRequest(string userName, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;

        }

        String username { get; set; }
        String password { get; set; }
        String email { get; set; }
    }
}
