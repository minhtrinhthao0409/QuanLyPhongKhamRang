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


        public async Task<bool> AddAppointmentAsync_v2(string doctorName, string patientName, string doctorEmail, string patientPhoneNo, DateTime date, TimeSpan start, TimeSpan end)
        {
            SQLiteConnection conn = null;
            SQLiteTransaction transaction = null;
            
            try
            {
                if (end <= start)
                    throw new Exception("Giờ kết thúc phải sau giờ bắt đầu.");

                if (date.Date < DateTime.Today)
                    throw new Exception("Không thể đặt lịch ở ngày quá khứ.");


                conn = await GetConnectionAsync();
                transaction = conn.BeginTransaction();


                Guid doctorId;
                Guid patientId;
                

                string getDoctorIdQuery = "SELECT Id FROM Users WHERE FullName = @FullName AND Email = @Email AND Role = @Role";
                await using (var getDoctorCmd = new SQLiteCommand(getDoctorIdQuery, conn, transaction))
                {
                    int role = 2;
                    getDoctorCmd.Parameters.AddWithValue("@FullName", doctorName);
                    getDoctorCmd.Parameters.AddWithValue("@Email", doctorEmail);
                    getDoctorCmd.Parameters.AddWithValue("@Role", role);
                    var result = await getDoctorCmd.ExecuteScalarAsync();

                    if (result == null)
                    {
                        throw new Exception("Thông tin bác sĩ không chính xác. Vui lòng kiểm tra lại thông tin bác sĩ.");
                    }

                    doctorId = Guid.Parse(result.ToString());
                }

                string getPatientIdQuery = "SELECT PatientId FROM Patients WHERE FullName = @FullName AND PhoneNumber = @PhoneNumber";
                await using (var getPatientCmd = new SQLiteCommand(getPatientIdQuery, conn, transaction))
                {
                    getPatientCmd.Parameters.AddWithValue("@FullName", patientName);
                    getPatientCmd.Parameters.AddWithValue("@PhoneNumber", patientPhoneNo);

                    var result = await getPatientCmd.ExecuteScalarAsync();

                    if (result == null)
                    {
                        throw new Exception("Thông tin bác sĩ không chính xác hoặc chưa có hồ sơ bệnh nhân!");
                    }
                    patientId = Guid.Parse(result.ToString());


                    string insertQuery = @"
                                            INSERT INTO Appointments (AppointmentId, DoctorId, PatientId, AppointmentDate, StartTime, EndTime)
                                            VALUES (@AppointmentId, @DoctorId, @PatientId, @AppointmentDate, @StartTime, @EndTime)";

                    await using var cmd = new SQLiteCommand(insertQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@AppointmentId", Guid.NewGuid().ToString());
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId.ToString());
                    cmd.Parameters.AddWithValue("@PatientId", patientId.ToString());
                    cmd.Parameters.AddWithValue("@AppointmentDate", date);
                    cmd.Parameters.AddWithValue("@StartTime", start);
                    cmd.Parameters.AddWithValue("@EndTime", end);

                    int affectedRows = await cmd.ExecuteNonQueryAsync();
                    await transaction.CommitAsync();

                    return affectedRows > 0;
                }
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


        public async Task<List<Appointment>> GetDoctorAppointmentsAsync_v2(DateTime startDate, DateTime? endDate = null, string doctorName = null, string patientPhone = null)
        {
            var list = new List<Appointment>();

            try
            {
                using var conn = await GetConnectionAsync();

                var cmd = new SQLiteCommand(conn);
                var whereClauses = new List<string>();

                string baseQuery = @"
                                        SELECT  a.AppointmentId, 
                                                a.DoctorId, u.FullName AS DoctorName, 
                                                a.PatientId, p.FullName AS PatientName,
                                                a.AppointmentDate, a.StartTime, a.EndTime
                                        FROM Appointments a
                                        JOIN Patients p ON a.PatientId = p.PatientId
                                        JOIN Users u ON a.DoctorId = u.Id
                                        WHERE ";

                
                if (endDate.HasValue)
                {
                    whereClauses.Add("DATE(a.AppointmentDate) BETWEEN DATE(@StartDate) AND DATE(@EndDate)");
                    cmd.Parameters.AddWithValue("@EndDate", endDate.Value.Date);
                }
                else
                {
                    whereClauses.Add("DATE(a.AppointmentDate) = DATE(@StartDate)");
                }

                cmd.Parameters.AddWithValue("@StartDate", startDate.Date);

                
                if (!string.IsNullOrWhiteSpace(doctorName))
                {
                    whereClauses.Add("u.FullName LIKE @DoctorName");
                    cmd.Parameters.AddWithValue("@DoctorName", $"%{doctorName}%");
                }

                // Điều kiện số điện thoại bệnh nhân
                if (!string.IsNullOrWhiteSpace(patientPhone))
                {
                    whereClauses.Add("p.PhoneNumber = @PatientPhone");
                    cmd.Parameters.AddWithValue("@PatientPhone", patientPhone);
                }

                // Ghép câu truy vấn đầy đủ
                baseQuery += string.Join(" AND ", whereClauses);
                cmd.CommandText = baseQuery;

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    list.Add(new Appointment
                    {
                        AppointmentId = reader["AppointmentId"]?.ToString() ?? string.Empty,
                        DoctorId = reader["DoctorId"]?.ToString() ?? string.Empty,
                        PatientId = reader["PatientId"]?.ToString() ?? string.Empty,
                        PatientName = reader["PatientName"]?.ToString() ?? string.Empty,
                        AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]).Date,
                        DoctorName = reader["DoctorName"].ToString() ?? string.Empty,
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

        public async Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            var list = new List<Appointment>();

            try
            {
                using var conn = await GetConnectionAsync();

                string query = @"
                                SELECT  a.AppointmentId, 
                                        a.DoctorId, u.FullName AS DoctorName, 
                                        a.PatientId, p.FullName AS PatientName,
                                        a.AppointmentDate, a.StartTime, a.EndTime
                                FROM Appointments a
                                JOIN Patients p ON a.PatientId = p.PatientId
                                JOIN Users u ON a.DoctorId = u.Id
                                WHERE DATE(a.AppointmentDate) >= DATE(@Today)
                                ORDER BY a.AppointmentDate ASC
                                LIMIT 10;"
;

                using var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);

                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    list.Add(new Appointment
                    {
                        AppointmentId = reader["AppointmentId"]?.ToString() ?? string.Empty,
                        DoctorId = reader["DoctorId"]?.ToString() ?? string.Empty,
                        PatientId = reader["PatientId"]?.ToString() ?? string.Empty,
                        PatientName = reader["PatientName"]?.ToString() ?? string.Empty,
                        AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]).Date,
                        DoctorName = reader["DoctorName"].ToString() ?? string.Empty,
                        StartTime = Convert.ToDateTime(reader["StartTime"]).TimeOfDay,
                        EndTime = Convert.ToDateTime(reader["EndTime"]).TimeOfDay,
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch hẹn: " + ex.Message);
            }

            return list;
        }


    }
}

