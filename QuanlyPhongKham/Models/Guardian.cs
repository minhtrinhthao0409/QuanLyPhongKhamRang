using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Guardian
    {
        public Guid GuardianId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Guardian()
        {
            Patients = new List<Patient>();
        }

        public Guardian(Guid id, string name, string phoneNumber, string email)
        {
            GuardianId = id;
            FullName = name;
            PhoneNumber = phoneNumber;
            Email = email;
            Patients = new List<Patient>();
        }

        
        public ICollection<Patient> Patients { get; set; }
    }

}
