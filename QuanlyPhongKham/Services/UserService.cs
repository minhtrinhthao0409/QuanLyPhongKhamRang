using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.repository;
using System.Data.SQLite;

namespace QuanlyPhongKham.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;
        private readonly string connectionString = "Data Source=QuanLyPhongKham.db;Version=3;";

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public async Task<bool> CreateAccountAsync(User user)
        {
            using var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = @"INSERT INTO Users (Id, UserName, Password, Email, FullName, PhoneNumber, Role)
                     VALUES (@Id, @UserName, @Password, @Email, @FullName, @PhoneNumber, @Role)";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@FullName", user.FullName);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@Role", user.Role);

            int rowsAffected = await cmd.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            using var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            string query = @"SELECT * FROM Users WHERE UserName = @username AND Password = @password";
            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new User
                {
                    Id = reader["Id"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    Email = reader["Email"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    Role = (UserRole)Convert.ToInt32(reader["Role"])
                };
            }
            return null;
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
            using var conn = new SQLiteConnection(connectionString);
            await conn.OpenAsync();

            var cmd = new SQLiteCommand("SELECT Password FROM Users WHERE Email = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            var result = await cmd.ExecuteScalarAsync();

            return result?.ToString();
        }
    }
}
