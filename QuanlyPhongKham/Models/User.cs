using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public enum UserRole
    {
        Admin = 1,
        Doctor = 2,
        Receptionist = 3
    }


    public class User
    {
        public Guid Id { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserRole Role { get; set; }

        public User() { }

        public User(string userName, string password, string email, UserRole role)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Role = role;
        }
    }

}
