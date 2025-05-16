using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.repository;

namespace QuanlyPhongKham.Services
{
    public class UserService
    {
        public  UserRepository userRepository;

        public UserService()
        {
            userRepository = new UserRepository();
        }

        public async Task<int> CreateUserAsync(string username, string email, string password)
        {
            if (!IsValidEmail(email))
                throw new ArgumentException("Email không hợp lệ.", nameof(email));

            string hashedPassword = PasswordHasher.HashPassword(password); 
            return await userRepository.CreateUserAsync(username, email, hashedPassword);
        }

        public async Task<bool> VerifyUserAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Tên người dùng và mật khẩu không được rỗng.");

            UserResponse user = await userRepository.GetUserAsync(username);
            if (user == null)
                return false;

            return PasswordHasher.VerifyPassword(password, user.Password); 
        }

        public async Task<String> GetPasswordByEmail (string email)
        {
            if (!IsValidEmail(email))
                return "Email không tồn tại";
            UserResponse user = await userRepository.GetUserByEmailAsync(email);

            return PasswordHasher.DecryptPassword(user.Password);

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
    }
}
