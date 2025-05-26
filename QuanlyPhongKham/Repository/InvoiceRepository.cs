using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using QuanlyPhongKham.Models;

namespace QuanlyPhongKham.Repository
{
    public class InvoiceRepository : BaseRepository
    {
        public InvoiceRepository(string connectionString = null) : base(connectionString) { }

        public async Task<int> CreateInvoiceAsync(Invoice invoice)
        {
            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertInvoiceSql = @"
                    INSERT INTO Invoice (PatientId, PatientName, CreatedAt, TotalAmount, PaidAmount, Status)
                    VALUES (@PatientId, @PatientName, @CreatedAt, @TotalAmount, @PaidAmount, @Status);
                    SELECT last_insert_rowid();";

                    int invoiceId;
                    using (var cmd = new SQLiteCommand(insertInvoiceSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientId", invoice.PatientId);
                        cmd.Parameters.AddWithValue("@PatientName", invoice.PatientName ?? "");
                        cmd.Parameters.AddWithValue("@CreatedAt", invoice.CreatedAt);
                        cmd.Parameters.AddWithValue("@TotalAmount", invoice.TotalAmount);
                        cmd.Parameters.AddWithValue("@PaidAmount", invoice.PaidAmount);
                        cmd.Parameters.AddWithValue("@Status", invoice.Status);

                        invoiceId = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    }

                    foreach (var detail in invoice.Details)
                    {
                        string insertDetailSql = @"
                        INSERT INTO InvoiceDetail (InvoiceId, ServiceName, UnitPrice, Quantity, TotalPrice)
                        VALUES (@InvoiceId, @ServiceName, @UnitPrice, @Quantity, @TotalPrice)";

                        using (var detailCmd = new SQLiteCommand(insertDetailSql, connection))
                        {
                            detailCmd.Parameters.AddWithValue("@InvoiceId", invoiceId);
                            detailCmd.Parameters.AddWithValue("@ServiceName", detail.ServiceName);
                            detailCmd.Parameters.AddWithValue("@UnitPrice", detail.UnitPrice);
                            detailCmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            detailCmd.Parameters.AddWithValue("@TotalPrice", detail.UnitPrice * detail.Quantity);

                            await detailCmd.ExecuteNonQueryAsync();
                        }
                    }

                    await transaction.CommitAsync();
                    return invoiceId;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi lưu hóa đơn", ex);
                }
            }
        }
        public async Task<List<MedicalService>> GetActiveServicesAsync()
        {
            var services = new List<MedicalService>();

            using (var conn = await GetConnectionAsync())
            {
                string query = "SELECT ServicesId, ServicesName, CurrentPrice FROM Services";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        services.Add(new MedicalService
                        {
                            ServicesId = reader["ServicesId"].ToString(),
                            ServicesName = reader["ServicesName"].ToString(),
                            CurrentPrice = Convert.ToDecimal(reader["CurrentPrice"])
                        });
                    }
                }
            }

            return services;
        }

        public async Task<List<Invoice>> SearchInvoicesAsync(string phoneNo, DateTime startDate, DateTime endDate)
        {
            var invoices = new List<Invoice>();

            using (var conn = await GetConnectionAsync())
            {
                var query = new StringBuilder(@"
                                SELECT i.InvoiceId, i.PatientId, i.PatientName, i.CreatedAt, i.TotalAmount, i.PaidAmount, i.Status
                                FROM Invoice i
                                JOIN Patients p ON i.PatientId = p.PatientId
                                WHERE i.CreatedAt >= @StartDate AND i.CreatedAt <= @EndDate");

                if (!string.IsNullOrWhiteSpace(phoneNo))
                    query.Append(" AND p.PhoneNumber LIKE @PhoneNo");

                using (var cmd = new SQLiteCommand(query.ToString(), conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@EndDate", endDate.Date.AddDays(1).AddTicks(-1)); // lấy đến cuối ngày

                    if (!string.IsNullOrWhiteSpace(phoneNo))
                        cmd.Parameters.AddWithValue("@PhoneNo", $"%{phoneNo}%");

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            invoices.Add(new Invoice
                            {
                                InvoiceId = Convert.ToInt32(reader["InvoiceId"]),
                                PatientId = reader["PatientId"].ToString(),
                                PatientName = reader["PatientName"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                PaidAmount = Convert.ToDecimal(reader["PaidAmount"]),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }

            return invoices;
        }

        public async Task<List<InvoiceDetail>> GetInvoiceDetailsAsync(int invoiceId)
        {
            var details = new List<InvoiceDetail>();

            using (var conn = await GetConnectionAsync())
            {
                string query = @"
                                    SELECT InvoiceDetailId, InvoiceId, ServiceName, UnitPrice, Quantity
                                    FROM InvoiceDetail
                                    WHERE InvoiceId = @InvoiceId";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceId", invoiceId);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            details.Add(new InvoiceDetail
                            {
                                InvoiceDetailId = Convert.ToInt32(reader["InvoiceDetailId"]),
                                InvoiceId = Convert.ToInt32(reader["InvoiceId"]),
                                ServiceName = reader["ServiceName"].ToString(),
                                UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                            });
                        }
                    }
                }
            }

            return details;
        }
        public async Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate)
        {
            decimal totalRevenue = 0;

            using (var conn = await GetConnectionAsync())
            {
                string query = @"
                    SELECT SUM(TotalAmount) AS TotalRevenue
                    FROM Invoice
                    WHERE CreatedAt BETWEEN @StartDate AND @EndDate";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd"));

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            totalRevenue = reader["TotalRevenue"] != DBNull.Value
                                ? Convert.ToDecimal(reader["TotalRevenue"])
                                : 0;
                        }
                    }
                }
            }

            return totalRevenue;
        }
        public async Task<List<Invoice>> GetInvoiceByTime(DateTime startDate, DateTime endDate)
        {
            var invoices = new List<Invoice>();
            using (var conn = await GetConnectionAsync())
            {
                string query = @"
                    SELECT InvoiceId, PatientId, PatientName, CreatedAt, TotalAmount, PaidAmount, Status
                    FROM Invoice
                    WHERE CreatedAt BETWEEN @StartDate AND @EndDate";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            invoices.Add(new Invoice
                            {
                                InvoiceId = Convert.ToInt32(reader["InvoiceId"]),
                                PatientId = reader["PatientId"].ToString(),
                                PatientName = reader["PatientName"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                TotalAmount = Convert.ToDecimal(reader["TotalAmount"]),
                                PaidAmount = Convert.ToDecimal(reader["PaidAmount"]),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
            }
            return invoices;
        }
    }

}

