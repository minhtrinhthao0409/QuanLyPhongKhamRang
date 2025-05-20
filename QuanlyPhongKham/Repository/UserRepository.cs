using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace QuanlyPhongKham.Repository
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(string connectionString = null) : base(connectionString) { }

        public async Task<bool> CheckUsernameExistsAsync(string username)
        {
            using var connection = await GetConnectionAsync();
            using var command = new SQLiteCommand("SELECT 1 FROM Users WHERE username = @username", connection);
            command.Parameters.AddWithValue("@username", username);
            var result = await command.ExecuteScalarAsync();
            return result != null;
        }

        public async Task<string> CreateUserAsync(User user)
        {
            using var connection = await GetConnectionAsync();
            using var transaction = connection.BeginTransaction();

            var cmd = new SQLiteCommand(@"
                INSERT INTO Users (Id, UserName, Password, Email, FullName, PhoneNumber, Role)
                VALUES (@Id, @UserName, @Password, @Email, @FullName, @PhoneNumber, @Role)", connection);

            cmd.Parameters.AddWithValue("@Id", user.Id);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@FullName", user.FullName);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
            cmd.Parameters.AddWithValue("@Role", (int)user.Role);

            await cmd.ExecuteNonQueryAsync();
            await transaction.CommitAsync();

            return user.Id;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            using var connection = await GetConnectionAsync();
            using var cmd = new SQLiteCommand("SELECT * FROM Users WHERE UserName = @UserName", connection);
            cmd.Parameters.AddWithValue("@UserName", username);

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new User
                {
                    Id = reader["Id"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    Role = (UserRole)Convert.ToInt32(reader["Role"])
                };
            }
            return null;
        }

        public async Task<User> GetByUsernameAndPasswordAsync(string username, string password)
        {
            using var conn = await GetConnectionAsync();

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

        public async Task<string> GetPasswordByEmailAsync(string email)
        {
            using var conn = await GetConnectionAsync();
            var cmd = new SQLiteCommand("SELECT Password FROM Users WHERE Email = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);
            var result = await cmd.ExecuteScalarAsync();
            return result?.ToString();
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            List<User> users = new List<User>();
            using var conn = await GetConnectionAsync();
            var cmd = new SQLiteCommand("SELECT * FROM Users", conn);
            using var reader = await cmd.ExecuteReaderAsync();
            while (true)
            {
                if (!await reader.ReadAsync())
                    break;
                users.Add(new User
                {
                    Id = reader["Id"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    Email = reader["Email"].ToString(),
                    FullName = reader["FullName"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    Role = (UserRole)Convert.ToInt32(reader["Role"])
                });
            }
            return users;
        }
    }
}
