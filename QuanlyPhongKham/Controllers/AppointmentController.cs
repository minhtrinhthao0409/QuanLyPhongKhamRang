using QuanlyPhongKham.Models;
using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;

namespace QuanlyPhongKham.Controllers
{
    public class AppointmentController
    {
        private readonly AppointmentService _service;

        public AppointmentController()
        {
            _service = new AppointmentService();
        }

        public List<AppointmentViewModel> GetAppointmentsByDoctor(string doctorUserId)
            => _service.GetAppointmentsByDoctor(doctorUserId);

        public List<Patient> GetAllPatients()
            => _service.GetAllPatients();

        public bool HasScheduleConflict(string doctorUserId, DateTime date, TimeSpan start, TimeSpan end)
            => _service.HasScheduleConflict(doctorUserId, date, start, end);

        public bool AddAppointment(string doctorUserId, string patientId, DateTime date, TimeSpan start, TimeSpan end)
            => _service.AddAppointment(doctorUserId, patientId, date, start, end);
    }
}
