using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class MedicalRecord
    {

        public int MedRecId { get; set; }

        public Guid PatientId { get; set; }

        public Patient Patient { get; set; }

        public string Details { get; set; }

        public DateTime Date { get; set; }


    }
}
