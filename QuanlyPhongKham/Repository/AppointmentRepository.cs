using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
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
                cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd")); 
                cmd.Parameters.AddWithValue("@StartTime", start.ToString(@"hh\:mm")); 
                cmd.Parameters.AddWithValue("@EndTime", end.ToString(@"hh\:mm"));

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
            SQLiteTransaction transaction = null;

            try
            {
                conn = await GetConnectionAsync();
                transaction = conn.BeginTransaction();

                string query = @"
                    INSERT INTO Appointments (AppointmentId, DoctorId, PatientId, AppointmentDate, StartTime, EndTime)
                    VALUES (@AppointmentId, @DoctorId, @PatientId, @AppointmentDate, @StartTime, @EndTime)";

                await using var cmd = new SQLiteCommand(query, conn, transaction);
                cmd.Parameters.AddWithValue("@AppointmentId", Guid.NewGuid().ToString());
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Parameters.AddWithValue("@AppointmentDate", date);
                cmd.Parameters.AddWithValue("@StartTime", start);
                cmd.Parameters.AddWithValue("@EndTime", end);

                int affectedRows = await cmd.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                return affectedRows > 0;
            }
            catch (SQLiteException ex)
            {
                if (transaction != null)
                {
                    await transaction.RollbackAsync();
                }
                throw new Exception("Lỗi khi thêm lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (transaction != null) await transaction.DisposeAsync();
                if (conn != null)
                {
                    await conn.CloseAsync();
                    await conn.DisposeAsync();
                }
            }
        }

        public async Task<List<Appointment>> GetDoctorAppointmentsAsync(string doctorId)
        {
            var list = new List<Appointment>();

            try
            {
                if (string.IsNullOrEmpty(doctorId))
                {
                    throw new ArgumentException("DoctorId không được rỗng.", nameof(doctorId));
                }

                using var conn = await GetConnectionAsync();
                string query = @"
                    SELECT a.AppointmentId, a.DoctorId, a.PatientId, p.FullName AS PatientName, 
                           a.AppointmentDate, a.StartTime, a.EndTime
                    FROM Appointments a
                    JOIN Patients p ON a.PatientId = p.PatientId
                    WHERE a.DoctorId = @DoctorId AND a.AppointmentDate >= @CurrentDate";

                using var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Today);

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    list.Add(new Appointment
                    {
                        AppointmentId = reader["AppointmentId"]?.ToString() ?? string.Empty,
                        DoctorId = reader["DoctorId"]?.ToString() ?? string.Empty,
                        PatientId = reader["PatientId"]?.ToString() ?? string.Empty,
                        PatientName = reader["PatientName"]?.ToString() ?? string.Empty,
                        AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]),
                        StartTime = Convert.ToDateTime(reader["StartTime"]).TimeOfDay,
                        EndTime = Convert.ToDateTime(reader["EndTime"]).TimeOfDay,
                    });
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Lỗi khi lấy danh sách lịch hẹn: " + ex.Message);
            }
            catch (FormatException ex)
            {
                throw new Exception("Lỗi định dạng ngày hoặc thời gian: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi không xác định: " + ex.Message);
            }

            return list;
        }
    }
}