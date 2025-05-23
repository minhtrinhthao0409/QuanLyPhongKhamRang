using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace QuanlyPhongKham.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private static readonly Random rand = new Random();
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<bool> CreateAccountAsync(User user)
        {
            string userId = await _userRepository.CreateUserAsync(user);
            return !string.IsNullOrEmpty(userId);
        }
        public async Task<User> AuthenticateAsync(string username, string password)
        {
            return await _userRepository.GetByUsernameAndPasswordAsync(username, password);
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> CheckUsernameExists(string username)
        {
            return await _userRepository.CheckUsernameExistsAsync(username);
        }
        public async Task<string> GetPasswordByEmail(string email)
        {
            return await _userRepository.GetPasswordByEmailAsync(email);
        }
        public async Task<string> ResetPasswordAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null) return null;

            string newPassword = GenerateRandomPassword();
            string hashedPassword = HashPassword(newPassword);

            await _userRepository.UpdatePasswordAsync(user.Id, hashedPassword);
            return newPassword;
        }

        private string GenerateRandomPassword(int length = 8)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rand.Next(s.Length)]).ToArray());
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return string.Concat(bytes.Select(b => b.ToString("x2")));
        }
        public async Task<List<User>> GetAllUser()
        {
            List<User> users = new List<User>();
            foreach (var user in await _userRepository.GetAllUserAsync())
            {
                if (user.active == 1)
                {
                    users.Add(user);
                }
            }
            return users;
        } 
    }
}
