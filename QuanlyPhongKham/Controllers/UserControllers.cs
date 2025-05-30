﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Services;
using System.Data.SQLite;

namespace QuanlyPhongKham.Controllers
{
    public class UserControllers
    {
        private readonly UserService _userService = new UserService();

        public async Task<bool> CreateAccount(string username, string password, string email, string fullName, string phone, int role)
        {
            var user = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = username,
                Password = password,
                Email = email,
                FullName = fullName,
                PhoneNumber = phone,
                Role = (UserRole)role
            };
            return await _userService.CreateAccountAsync(user);
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            return await _userService.AuthenticateAsync(username, password);
        }

        public async Task<string> GetPasswordByEmail(string email)
        {
            return await _userService.GetPasswordByEmail(email);
        }
        public async Task<List<User>> GetAllUser()
        {
            return await _userService.GetAllUser();
        }

        public async Task<bool> CheckUsernameExists(string username)
        {
            return await _userService.CheckUsernameExists(username);
        }
        public async Task<bool> UpdateUserAsync(string userName, string password, string fullName, string email, string phoneNumber)
        {
            return await _userService.UpdateUserAsync(userName, password, fullName, email, phoneNumber);
        }

        public async Task<bool> DeleteUserAsync(string userName)
        {
            return await _userService.DeleteUserAsync(userName);
        }

        public async Task<List<(string DoctorName, int AppointmentCount)>> GetDoctorAppointmentRankingAsync()
        {
            return await _userService.GetDoctorAppointmentRankingAsync();
        }
    }
}
