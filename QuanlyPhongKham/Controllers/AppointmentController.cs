using QuanlyPhongKham.Models;
using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Controllers
{
    public class AppointmentController
    {
        private readonly AppointmentService _service;

        public AppointmentController()
        {
            _service = new AppointmentService();
        }
        
        //Kiểm tra trùng lịch hẹn
        public async Task<bool> HasScheduleConflictAsync(string doctorId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
            => await _service.HasScheduleConflictAsync(doctorId, patientId, date, start, end);

        //Bác sĩ thêm lịch hẹn
        public async Task<bool> AddAppointmentAsync(string doctorId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
            => await _service.AddAppointmentAsync(doctorId, patientId, date, start, end);

        //Load lịch hẹn của bác sĩ
        public async Task<List<Appointment>> GetDoctorAppointmentsAsync(string doctorId)
            => await _service.GetDoctorAppointmentsAsync(doctorId);
    }
}