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
        public String username { get; set; }
        public String password { get; set; }
       
        public String email { get; set; }
        public UserResponse() { }

        public UserResponse(Guid id, string userName,String password, string email)
        {
            Id = id;
            this.username = userName;
            this.email = email;
            this.password = password;
        }
    }
}
