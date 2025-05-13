using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; } = null!;
        public DateTime DOB { get; set; }

        public Patient(Guid id, string name, string phoneNumber, string email, DateTime dob)
        {
            PatientId = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            DOB = dob;
        }

        public Patient()
        {

        }
        

        //public ICollection<MedicalRecord> hso = [];

    }
}
