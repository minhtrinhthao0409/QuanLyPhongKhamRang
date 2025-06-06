﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string DoctorId { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string DoctorName { get; set; }
        public int PaymentStatus { get; set; }

        public Appointment() 
        {
            AppointmentId = Guid.NewGuid().ToString();
        }

    }
}
