using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public Guid DoctorId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        // "Available", "Booked", "Off"
        public string Status { get; set; } = "Available";

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}

