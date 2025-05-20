using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System.Data.SQLite;

namespace QuanlyPhongKham.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

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
        public async Task<string> GetPasswordByEmail(string email)
        {
            return await _userRepository.GetPasswordByEmailAsync(email);
        }
    }
}
