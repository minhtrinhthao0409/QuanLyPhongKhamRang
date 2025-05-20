using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace QuanlyPhongKham.Repository
{
    public class AppointmentRepository : BaseRepository
    {
        public List<Appointment> GetAppointmentsByDoctor(string doctorUserId)
        {
            var list = new List<Appointment>();

            using var connection = GetConnection();
            connection.Open();

            string query = @"
                SELECT a.AppointmentId, a.AppointmentDate, a.StartTime, a.EndTime,
                       p.FullName AS PatientName
                FROM Appointments a
                JOIN Patients p ON a.PatientId = p.PatientId
                WHERE a.DoctorUserId = @DoctorUserId
                ORDER BY a.AppointmentDate, a.StartTime;
            ";

            using var command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@DoctorUserId", doctorUserId);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Appointment
                {
                    AppointmentId = reader["AppointmentId"].ToString(),
                    PatientName = reader["PatientName"].ToString(),
                    AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString()),
                    StartTime = TimeSpan.Parse(reader["StartTime"].ToString()),
                    EndTime = TimeSpan.Parse(reader["EndTime"].ToString())
                });
            }

            return list;
        }

        public List<Patient> GetAllPatients()
        {
            var list = new List<Patient>();

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SQLiteCommand("SELECT PatientId, FullName FROM Patients", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Patient
                {
                    PatientId = Guid.Parse(reader["PatientId"].ToString()),
                    Name = reader["FullName"].ToString()
                });
            }

            return list;
        }

        public bool HasScheduleConflict(string doctorUserId, DateTime date, TimeSpan start, TimeSpan end)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = @"
                SELECT COUNT(*) FROM Appointments
                WHERE DoctorUserId = @DoctorUserId
                AND AppointmentDate = @Date
                AND (StartTime < @EndTime AND EndTime > @StartTime);";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@DoctorUserId", doctorUserId);
            cmd.Parameters.AddWithValue("@Date", date.Date);
            cmd.Parameters.AddWithValue("@StartTime", start);
            cmd.Parameters.AddWithValue("@EndTime", end);

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }

        public bool AddAppointment(string doctorUserId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = @"
                INSERT INTO Appointments (AppointmentId, DoctorUserId, PatientId, AppointmentDate, StartTime, EndTime)
                VALUES (@Id, @DoctorUserId, @PatientId, @Date, @StartTime, @EndTime);";

            using var cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
            cmd.Parameters.AddWithValue("@DoctorUserId", doctorUserId);
            cmd.Parameters.AddWithValue("@PatientId", patientId);
            cmd.Parameters.AddWithValue("@Date", date.Date);
            cmd.Parameters.AddWithValue("@StartTime", start);
            cmd.Parameters.AddWithValue("@EndTime", end);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
