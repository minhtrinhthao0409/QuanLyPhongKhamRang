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

        public Guid PatientId { get; set; }

        
        public Patient Patient { get; set; }
    }
}
