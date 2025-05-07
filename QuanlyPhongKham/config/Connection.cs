using Npgsql;
using System;
using System.Configuration;

namespace QuanlyPhongKham
{
    public static class Connection
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
        
        /// <summary>
        /// Trả về một kết nối Npgsql mới đến cơ sở dữ liệu PostgreSQL.
        /// </summary>
        /// <returns>Một đối tượng NpgsqlConnection.</returns>
        /// <exception cref="InvalidOperationException">Ném ra nếu chuỗi kết nối không được cấu hình.</exception>
        public static NpgsqlConnection GetNpgsqlConnection()
        {
            Console.WriteLine(ConnectionString);
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new InvalidOperationException("Connection string 'DefaultConnection' is not configured in App.config.");
            }

            return new NpgsqlConnection(ConnectionString);
        }

        /// <summary>
        /// Kiểm tra xem kết nối đến cơ sở dữ liệu có thành công hay không.
        /// </summary>
        /// <returns>True nếu kết nối thành công, False nếu thất bại.</returns>
        public static bool TestConnection()
        {
            try
            {
                using (NpgsqlConnection connection = GetNpgsqlConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (NpgsqlException ex)
            {
                System.IO.File.AppendAllText("error.log",
                    $"[{DateTime.Now}] Database connection error: {ex.Message} | StackTrace: {ex.StackTrace}\n");
                return false;
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("error.log",
                    $"[{DateTime.Now}] General error: {ex.Message} | StackTrace: {ex.StackTrace}\n");
                return false;
            }
        }
    }
}