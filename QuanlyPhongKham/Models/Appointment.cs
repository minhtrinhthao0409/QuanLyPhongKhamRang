using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string DoctorUserId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }

        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public int PaymentStatus { get; set; }

        public Appointment() { }

    }

}
