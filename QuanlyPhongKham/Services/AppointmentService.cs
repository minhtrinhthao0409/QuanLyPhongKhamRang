using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Services
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _repository;
        private readonly PatientRepository _patiensrepository;

        public AppointmentService()
        {
            _repository = new AppointmentRepository();
        }

        public async Task<bool> HasScheduleConflictAsync(string doctorId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
            => await _repository.HasScheduleConflictAsync(doctorId, patientId, date, start, end);

        public async Task<bool> AddAppointmentAsync(string doctorId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
        {
            if (await HasScheduleConflictAsync(doctorId, patientId, date, start, end))
                return false;

            return await _repository.AddAppointmentAsync(doctorId, patientId, date, start, end);
        }

        public async Task<List<Appointment>> GetDoctorAppointmentsAsync(string doctorId)
            => await _repository.GetDoctorAppointmentsAsync(doctorId);

        public async Task<bool> AddAppointmentAsync_v2(string doctorName, string patientName,string doctorEmail, string patientPhoneNo, DateTime date, TimeSpan start, TimeSpan end)
        {
            return await _repository.AddAppointmentAsync_v2(doctorName, patientName, doctorEmail, patientPhoneNo, date, start, end);
        }

        public async Task<List<Appointment>> GetDoctorAppointmentsAsync_v2(DateTime startDate, DateTime? endDate, string doctorName = null, string patientPhone = null)
        {
            return await _repository.GetDoctorAppointmentsAsync_v2(startDate,  endDate, doctorName, patientPhone);
        }

        public async Task<List<Appointment>> GetAllAppointmentsAsync()
        {
            return await _repository.GetAllAppointmentsAsync();
        }
    }
}