using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid PatientId { get; set; }

        public DateTime AppointmentTime { get; set; }
        public string PaymentStatus { get; set; }

        public Appointment(int appointmentId, Guid doctorId, Guid patientId, DateTime appointmentTime, string paymentStatus)
        {
            AppointmentId = appointmentId;
            DoctorId = doctorId;
            PatientId = patientId;
            AppointmentTime = appointmentTime;
            PaymentStatus = paymentStatus;
        }
    }

}
