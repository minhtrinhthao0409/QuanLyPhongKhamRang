using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Repository
{
    public class AppointmentRepository : BaseRepository
    {
        public AppointmentRepository(string connectionString = null) : base(connectionString) { }

        public async Task<bool> HasScheduleConflictAsync(string doctorId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
        {
            try
            {
                using var conn = await GetConnectionAsync();
                using var cmd = new SQLiteCommand(@"
                    SELECT COUNT(*) FROM Appointments
                    WHERE (DoctorId = @DoctorId OR PatientId = @PatientId)
                    AND AppointmentDate = @Date
                    AND (StartTime < @EndTime AND EndTime > @StartTime)", conn);

                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                cmd.Parameters.AddWithValue("@StartTime", start.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@EndTime", end.ToString(@"hh\:mm\:ss"));

                long count = Convert.ToInt64(await cmd.ExecuteScalarAsync());
                return count > 0;
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Lỗi khi kiểm tra xung đột lịch hẹn: " + ex.Message);
            }
        }

        public async Task<bool> AddAppointmentAsync(string doctorId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
        {
            SQLiteConnection conn = null;
            SQLiteTransaction transaction = null; // Khai báo transaction ngoài khối try

            try
            {
                conn = await GetConnectionAsync();
                transaction = conn.BeginTransaction(); // Khởi tạo transaction

                string query = @"
                INSERT INTO Appointments (AppointmentId, DoctorId, PatientId, AppointmentDate, StartTime, EndTime)
                VALUES (@AppointmentId, @DoctorId, @PatientId, @Date, @StartTime, @EndTime)";

                using var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@AppointmentId", Guid.NewGuid().ToString());
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@Date", date.Date);
                cmd.Parameters.AddWithValue("@StartTime", start.ToString(@"hh\:mm\:ss"));
                cmd.Parameters.AddWithValue("@EndTime", end.ToString(@"hh\:mm\:ss"));

                int affectedRows = await cmd.ExecuteNonQueryAsync();
                transaction.Commit(); // Commit giao dịch

                return affectedRows > 0;
            }
            catch (SQLiteException ex)
            {
                // Rollback nếu có lỗi
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw new Exception("Lỗi khi thêm lịch hẹn: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối và giải phóng tài nguyên
                if (transaction != null)
                {
                    transaction.Dispose();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        public async Task<List<Appointment>> GetDoctorAppointmentsAsync(string doctorId)
        {
            var list = new List<Appointment>();

            try
            {
                using var conn = await GetConnectionAsync();
                string query = @"
                    SELECT a.AppointmentId, a.DoctorId, a.PatientId, p.Name AS PatientName, a.AppointmentDate, a.StartTime, a.EndTime
                    FROM Appointments a
                    JOIN Patients p ON a.PatientId = p.PatientId
                    WHERE a.DoctorId = @DoctorId AND a.AppointmentDate >= @CurrentDate";
                using var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Today); // 20/05/2025

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    list.Add(new Appointment
                    {
                        AppointmentId = reader["AppointmentId"].ToString(),
                        DoctorId = reader["DoctorId"].ToString(),
                        PatientId = reader["PatientId"].ToString(),
                        PatientName = reader["PatientName"].ToString(),
                        AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString()),
                        StartTime = TimeSpan.Parse(reader["StartTime"].ToString()),
                        EndTime = TimeSpan.Parse(reader["EndTime"].ToString())
                    });
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Lỗi khi lấy danh sách lịch hẹn: " + ex.Message);
            }

            return list;
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            var list = new List<Patient>();

            try
            {
                using var conn = await GetConnectionAsync();
                string query = "SELECT PatientId, Name FROM Patients";

                using var cmd = new SQLiteCommand(query, conn);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    if (reader["PatientId"] != DBNull.Value && reader["Name"] != DBNull.Value)
                    {
                        list.Add(new Patient
                        {
                            PatientId = reader["PatientId"].ToString(),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Lỗi khi lấy danh sách bệnh nhân: " + ex.Message);
            }

            return list;
        }
    }
}