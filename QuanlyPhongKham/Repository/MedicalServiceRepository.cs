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
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Services WHERE ServicesName = @name and ServiceActive = 1", connection);
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
                var cmd = new SQLiteCommand("SELECT CurrentPrice FROM Services WHERE ServicesName = @name and ServiceActive = 1", connection);
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
                var cmd = new SQLiteCommand("Select * from Services where ServiceActive = 1", connection);
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
                            ServiceActive = (int)reader["ServiceActive"]
                        };
                        services.Add(service);
                    }
                    return services;
                }
            }
        }
        // Tạo ID cho dịch vụ
        public async Task<int> CountService()
        {
            using (var connection = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Services", connection);
                return Convert.ToInt32(await cmd.ExecuteScalarAsync());
            }
        }
        public async Task<bool> AddService(string servicename, decimal serviceprice)
        {
            int count = await CountService() + 1;
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
                var cmd = new SQLiteCommand("UPDATE Services SET ServiceActive = 0 WHERE ServicesName = @name and ServiceActive = 1", connection);
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
                var cmd = new SQLiteCommand("UPDATE Services SET CurrentPrice = @newPrice WHERE ServicesName = @name and ServiceActive = 1", connection);
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

        public async Task<List<(string ServiceName, decimal TotalRevenue)>> GetTopServiceRevenueAsync()
        {
            var serviceRevenues = new List<(string ServiceName, decimal TotalRevenue)>();
            using var connection = await GetConnectionAsync();

            string query = @"
            SELECT s.ServicesName, SUM(id.TotalPrice) as TotalRevenue
            FROM services s
            JOIN invoicedetail id ON s.ServicesName = id.ServiceName
            JOIN invoice i ON id.InvoiceId = i.InvoiceId
            WHERE i.CreatedAt BETWEEN date('2025-05-27', '-30 days') AND datetime('2025-05-27 23:59:59')
            GROUP BY s.ServicesName
            ORDER BY TotalRevenue DESC;";
            //  WHERE i.CreatedAt BETWEEN date('2025-05-27', '-30 days') AND datetime('2025-05-27 23:59:59') And Status = ""Đã thanh toán""
            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@Status", "Đã thanh toán");

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                serviceRevenues.Add((
                    reader["ServicesName"].ToString(),
                    Convert.ToDecimal(reader["TotalRevenue"])
                ));
            }

            return serviceRevenues;
        }
    }
}
