using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;

namespace QuanlyPhongKham.Services
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _repository;

        public AppointmentService()
        {
            _repository = new AppointmentRepository();
        }

        public List<Patient> GetAllPatients()
            => _repository.GetAllPatients();

        public bool HasScheduleConflict(string doctorUserId, DateTime date, TimeSpan start, TimeSpan end)
            => _repository.HasScheduleConflict(doctorUserId, date, start, end);

        public bool AddAppointment(string doctorUserId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
        {
            if (HasScheduleConflict(doctorUserId, date, start, end))
                return false;

            return _repository.AddAppointment(doctorUserId, patientId, date, start, end);
        }
    }
}
