﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham
{
    public class User
    {
        public User(string userName, string password, string email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        String userName { get; set; }
        String password { get; set; }
        String email {  get; set; }

    }
}
