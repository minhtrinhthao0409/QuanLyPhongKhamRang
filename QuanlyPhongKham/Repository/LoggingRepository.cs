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
    class LoggingRepository : BaseRepository
    {
        public LoggingRepository(string connectionString = null) : base(connectionString) { }

        public async Task<bool> AddLoggingAsync(string UserID, string UserName, string Content)
        {
            try
            {
                using var connection = await GetConnectionAsync();
                // Không cần gọi OpenAsync() vì GetConnectionAsync đã mở kết nối

                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Loggings (LoggingID, UserID, UserName, Content, DateTime) VALUES (@LoggingID, @UserID, @UserName, @Content, @DateTime)";

                command.Parameters.AddWithValue("@LoggingID", Guid.NewGuid().ToString());
                command.Parameters.AddWithValue("@UserID", UserID ?? string.Empty); // Xử lý null
                command.Parameters.AddWithValue("@UserName", UserName ?? string.Empty); // Xử lý null
                command.Parameters.AddWithValue("@Content", Content ?? string.Empty); // Xử lý null
                command.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                int rowsAffected = await command.ExecuteNonQueryAsync();
                return rowsAffected > 0; // Trả về true nếu INSERT thành công
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm log: {ex.Message}");
                throw; // Ném lại ngoại lệ để lớp gọi xử lý
            }
        }

        public async Task<List<Logging>> GetAllLoggingsAsync()
        {
            var result = new List<Logging>();

            try
            {
                using var connection = await GetConnectionAsync();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT LoggingID, UserID, UserName, Content, DateTime FROM Loggings";

                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var logging = new Logging
                    {
                        LoggingID = reader["LoggingID"] != DBNull.Value ? reader["LoggingID"].ToString() : string.Empty,
                        UserID = reader["UserID"] != DBNull.Value ? reader["UserID"].ToString() : string.Empty,
                        UserName = reader["UserName"] != DBNull.Value ? reader["UserName"].ToString() : string.Empty,
                        Content = reader["Content"] != DBNull.Value ? reader["Content"].ToString() : string.Empty,
                        DateTime = reader["DateTime"] != DBNull.Value ? reader["DateTime"].ToString() : string.Empty
                    };
                    result.Add(logging);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi kết nối SQLite: {ex.Message}");
                throw;
            }

            return result;
        }
    }
}
