using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Repository
{
    internal class MedicalServiceRepository : BaseRepository
    {
        public MedicalServiceRepository(string connectionString = null) : base(connectionString)
        {
        }

        // Kiểm tra xem dịch vụ có tồn tại hay không
        public async Task<bool> CheckServiceExists(string serviceName)
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Services WHERE ServicesName = @name", connection);
                cmd.Parameters.AddWithValue("@name", serviceName);
                var result = await cmd.ExecuteScalarAsync();
                return Convert.ToInt32(result) > 0;
            }
        }

        /// Lấy giá dịch vụ theo tên
        public decimal? LayGiaDichVuTheoTen(string tenDichVu)
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT CurrentPrice FROM Services WHERE ServicesName = @name", connection);
                cmd.Parameters.AddWithValue("@name", tenDichVu);

                var result = cmd.ExecuteScalar();
                if (result != null && decimal.TryParse(result.ToString(), out decimal gia))
                    return gia;

                return null;
            }
        }

        // Lấy tất cả dịch vụ
        public async Task<List<MedicalService>> GetAllService()
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT ServicesID, ServicesName, CurrentPrice from \"services\"", connection);
                //var cmd = new SQLiteCommand("Select ServicesId, ServicesName, CurrentPrice from Services where ServiceActive = 1", connection);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var services = new List<MedicalService>();
                    while (await reader.ReadAsync())
                    {
                        var service = new MedicalService
                        {
                            ServicesId = reader["ServicesId"].ToString(),
                            ServicesName = reader["ServicesName"].ToString(),
                            CurrentPrice = decimal.Parse(reader["CurrentPrice"].ToString()),
                        };
                        services.Add(service);
                    }
                    return services;
                }
            }
        }
        // Tạo ID cho dịch vụ
        public async Task<int> CountActiveService()
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Services WHERE ServiceActive = 1", connection);
                return Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
        }
        public async Task<bool> AddService(string servicename, decimal serviceprice)
        {
            int count = await CountActiveService() + 1;
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Services (ServicesId, ServicesName, CurrentPrice) VALUES (@id, @name, @price)", connection);
                cmd.Parameters.AddWithValue("@id", count);
                cmd.Parameters.AddWithValue("@name", servicename);
                cmd.Parameters.AddWithValue("@price", serviceprice);
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }
        // Xóa dịch vụ
        public async Task<bool> DeleteService(string serviceName)
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Services SET ServiceActive = 0 WHERE ServicesName = @name", connection);
                // đã dùng trigger + 100000 cho update < 0
                cmd.Parameters.AddWithValue("@name", serviceName);
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }

        // Sửa giá dịch vụ (chỉ cho sửa giá vì nếu cho sửa cả 2 khác gì chức năng xóa)
        public async Task<bool> UpdateServicePrice(string serviceName, decimal newPrice)
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Services SET CurrentPrice = @newPrice WHERE ServicesName = @name", connection);
                cmd.Parameters.AddWithValue("@newPrice", newPrice);
                cmd.Parameters.AddWithValue("@name", serviceName);
                return await cmd.ExecuteNonQueryAsync() > 0;
            }
        }

        // Sắp xếp dịch vụ theo số lượng đã dùng
        public async Task<List<MedicalService>> SortServiceByCount()
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT s.servicesname, COUNT(*) as usage_count\r\nFROM services s\r\nJOIN invoicedetail id ON s.servicesname = id.servicename\r\nGROUP BY s.servicesname\r\nORDER BY usage_count DESC;", connection);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    var services = new List<MedicalService>();
                    while (await reader.ReadAsync())
                    {
                        var service = new MedicalService
                        {
                            ServicesId = reader["ServicesId"].ToString(),
                            ServicesName = reader["ServicesName"].ToString(),
                            CurrentPrice = decimal.Parse(reader["CurrentPrice"].ToString()),
                        };
                        services.Add(service);
                    }
                    return services;
                }
            }
        }
    }
}
