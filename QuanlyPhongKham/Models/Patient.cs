using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Patient
    {
        public string PatientId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; } = false;
        public string PhoneNumber { get; set; }
        public string Email { get; set; } = null!;

        public Guid? GuardianId { get; set; }         
        public Guardian? Guardian { get; set; }       

        public Patient()
        {
            PatientId = Guid.NewGuid().ToString();
            MedRec = [];
            Appointments = [];
        }

        public Patient(string id, string name, bool gender, string phoneNumber, string email, DateTime dob, Guid? guardianId = null)
        {
            PatientId = id;
            Name = name;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            DOB = dob;
            GuardianId = guardianId;

            MedRec = [];
            Appointments = [];
        }

        public ICollection<MedicalRecord> MedRec { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
