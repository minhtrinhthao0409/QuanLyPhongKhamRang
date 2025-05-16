using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class UserResponse
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserRole Role { get; set; }

        public UserResponse() { }

        public UserResponse(Guid id, string userName, string password, string email, UserRole role)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
            Role = role;
        }
    }

}
