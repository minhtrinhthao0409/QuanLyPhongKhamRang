using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using System.Data.SQLite;



namespace QuanlyPhongKham.repository
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
            string userId = Guid.NewGuid().ToString();

            using var connection = await GetConnectionAsync();
            using var transaction = connection.BeginTransaction();

            var cmd = new SQLiteCommand(@"INSERT INTO Users (Id, UserName, Password, Email, Role) 
                                      VALUES (@Id, @UserName, @Password, @Email, @Role)", connection);

            cmd.Parameters.AddWithValue("@Id", userId);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Role", (int)user.Role);

            await cmd.ExecuteNonQueryAsync();
            await transaction.CommitAsync();
            return userId;
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
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    Role = (UserRole)Convert.ToInt32(reader["Role"])
                };
            }
            return null;
        }
    }

}
