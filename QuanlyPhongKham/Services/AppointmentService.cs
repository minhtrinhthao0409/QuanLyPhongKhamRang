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

        public AppointmentService()
        {
            _repository = new AppointmentRepository();
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
            => await _repository.GetAllPatientsAsync();

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
    }
}