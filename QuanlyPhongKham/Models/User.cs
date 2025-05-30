﻿using System;
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
        public string Id { get; set; }
        public string UserName { get; set; }
        private string password;
        public string Password {
            get => password;
            set => password = PasswordHasher.HashPassword(value);
        }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public int active { get; set; } = 1; // 1: active, 0: inactive
        public UserRole Role { get; set; }
        public User() 
        {
            Id = Guid.NewGuid().ToString();
        }

        public User(string userName, string password, string email, UserRole role)
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
            Password = password;
            Email = email;
            Role = role;
        }

        public User(string Id, string UserName, string Password, string Email, string FullName, string PhoneNumber, UserRole role, int active)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            this.Role = role;
            this.active = active;
        }
    }
}
