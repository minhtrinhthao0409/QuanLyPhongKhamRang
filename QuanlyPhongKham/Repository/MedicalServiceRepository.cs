using System;
using System.Data.SQLite;

namespace QuanlyPhongKham.Repository
{
    internal class MedicalServiceRepository : BaseRepository
    {
        public MedicalServiceRepository(string connectionString = null) : base(connectionString)
        {
        }

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
    }
}
