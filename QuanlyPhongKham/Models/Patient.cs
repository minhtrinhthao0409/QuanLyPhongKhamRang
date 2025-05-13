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

        //public ICollection<MedicalRecord> hso = [];

    }
}
