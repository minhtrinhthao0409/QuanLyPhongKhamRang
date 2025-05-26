using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanlyPhongKham.Repository
{
    class LoggingRepository: BaseRepository
    {
        public LoggingRepository(string connectionString = null) : base(connectionString) { }

        public async Task<bool> AddLoggingAsync(string UserID, string UserName, string Content)
        {
            using var connection = await GetConnectionAsync();
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandText = @"INSERT INTO Loggings (LoggingID, UserID, UserName, Content, DateTime) VALUES (@LoggingID, @UserID, @UserName, @Content, @DateTime)";

            command.Parameters.AddWithValue("@LoggingID", Guid.NewGuid().ToString());
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Content", Content);
            command.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            await command.ExecuteNonQueryAsync();
            return true;
        }

        public async Task<List<Logging>> GetAllLoggingsAsync()
        {
            var result = new List<Logging>();

            using var connection = await GetConnectionAsync();
            await connection.OpenAsync();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Loggings ORDER BY DateTime DESC";

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var logging = new Logging
                {
                    LoggingID = reader["LoggingID"].ToString(),
                    UserID = reader["UserID"].ToString(),
                    UserName = reader["UserName"].ToString(),
                    Content = reader["Content"].ToString(),
                    DateTime = reader["DateTime"].ToString()
                };
                result.Add(logging);
            }

            return result;
        }

    }
}
