using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Npgsql;
using Microsoft.Data.Sqlite;
using QuanlyPhongKham.Models;


namespace QuanlyPhongKham.repository
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(string connectionString = null) : base(connectionString)
        {
        }

        public async Task<bool> CheckUsernameExistsAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Tên người dùng không được rỗng.", nameof(username));

            using (var connection = await GetConnectionAsync())
            using (var command = new SqliteCommand("SELECT EXISTS (SELECT 1 FROM Users WHERE username = @username)" ,connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@username", username);
                    var result = await command.ExecuteScalarAsync();
                    return Convert.ToBoolean(result);
                }
                catch (SqliteException ex)
                {
                    throw new Exception("Lỗi cơ sở dữ liệu khi kiểm tra tên người dùng.", ex);
                }
            }
        }

        public async Task<int> CreateUserAsync(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Tên người dùng không được rỗng.", nameof(username));
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email không được rỗng.", nameof(email));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Mật khẩu không được rỗng.", nameof(password));
            int affectedRows = 0;
            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    // Kiểm tra trùng username
                    using (var command = new SqliteCommand("SELECT EXISTS (SELECT 1 FROM Users WHERE username = @username)", connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        bool exists = Convert.ToBoolean(await command.ExecuteScalarAsync());
                        if (exists)
                            throw new Exception("Tên người dùng đã tồn tại.");
                    }

                    // Tạo người dùng mới
                    using (var command = new SqliteCommand(
                        "INSERT INTO users ( username, email, password) VALUES ( @username, @email, @password)",
                        connection))
                    {
                        
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        affectedRows = await command.ExecuteNonQueryAsync();
                    }

                     await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi tạo người dùng.", ex);
                }
            }
            return affectedRows;
        }

        public async Task<UserResponse> GetUserAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Tên người dùng không được rỗng.", nameof(username));

            UserResponse userResponse = null;

            using (var connection = await GetConnectionAsync())
            using (var command = new SqliteCommand("SELECT id, username, email, password FROM users WHERE username = @username", connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            userResponse = new UserResponse
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                UserName = reader.GetString(reader.GetOrdinal("username")),
                                Email = reader.IsDBNull(reader.GetOrdinal("email"))
                                        ? null
                                        : reader.GetString(reader.GetOrdinal("email")),
                                Password = reader.IsDBNull(reader.GetOrdinal("password"))
                                        ? null
                                        : reader.GetString(reader.GetOrdinal("password"))

                            };
                        }
                    }
                }
                catch (SqliteException ex)
                {
                    throw new Exception("Lỗi cơ sở dữ liệu khi lấy thông tin người dùng.", ex);
                }
            }

            return userResponse;
        }
        public async Task<UserResponse> GetUserByEmailAsync(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Tên email không được rỗng.", nameof(email));

            UserResponse userResponse = null;

            using (var connection = await GetConnectionAsync())
            using (var command = new SqliteCommand("SELECT id, username, email, password FROM users WHERE email = @email", connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@email", email);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            userResponse = new UserResponse
                            {
                                Id = reader.GetGuid(reader.GetOrdinal("id")),
                                UserName = reader.GetString(reader.GetOrdinal("username")),
                                Email = reader.IsDBNull(reader.GetOrdinal("email"))
                                        ? null
                                        : reader.GetString(reader.GetOrdinal("email")),
                                Password = reader.IsDBNull(reader.GetOrdinal("password"))
                                        ? null
                                        : reader.GetString(reader.GetOrdinal("password"))

                            };
                        }
                    }
                }
                catch (SqliteException ex)
                {
                    throw new Exception("Lỗi cơ sở dữ liệu khi lấy thông tin người dùng.", ex);
                }
            }

            return userResponse;
        }
    }
}

    

