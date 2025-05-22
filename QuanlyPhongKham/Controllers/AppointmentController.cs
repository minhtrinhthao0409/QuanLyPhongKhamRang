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

        public async Task<bool> AddAppointmentAsync_v2(string doctorName, string patientName, string doctorPhoneNo, string patientPhoneNo, DateTime date, TimeSpan start, TimeSpan end)
        {
            return await _service.AddAppointmentAsync_v2(doctorName, patientName, doctorPhoneNo, patientPhoneNo, date, start,end);
        }

        public async Task<List<Appointment>> GetDoctorAppointmentsAsync_v2(DateTime startDate, DateTime? endDate, string doctorName = null, string patientPhone = null)
        {
            return await _service.GetDoctorAppointmentsAsync_v2(startDate, endDate, doctorName, patientPhone);
        }

        public async Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            return await _service.GetAllAppointmentsAsync();
        }
    }
}