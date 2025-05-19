using QuanlyPhongKham.Models;
using QuanlyPhongKham.Views.Receptionist;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace QuanlyPhongKham.Controllers
{
    public class AppointmentController
    {
        private readonly string connectionString = "Data Source=QuanLyPhongKham.db";

        public List<AppointmentViewModel> GetAppointmentsByDoctor(string doctorUserId)
        {
            var list = new List<AppointmentViewModel>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT a.AppointmentId, a.AppointmentDate, a.StartTime, a.EndTime,
                   p.FullName AS PatientName
            FROM Appointments a
            JOIN Patients p ON a.PatientId = p.Id
            WHERE a.DoctorUserId = @DoctorUserId
            ORDER BY a.AppointmentDate, a.StartTime;
        ";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorUserId", doctorUserId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new AppointmentViewModel
                            {
                                AppointmentId = reader["AppointmentId"].ToString(),
                                PatientName = reader["PatientName"].ToString(),
                                AppointmentDate = DateTime.Parse(reader["AppointmentDate"].ToString()),
                                StartTime = TimeSpan.Parse(reader["StartTime"].ToString()),
                                EndTime = TimeSpan.Parse(reader["EndTime"].ToString())
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}
