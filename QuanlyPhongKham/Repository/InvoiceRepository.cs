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
    }
}
