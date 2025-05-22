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

        public string MedRecId { get; set; }
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public string Symptoms { get; set; }
        public string Diagnosis { get; set; }
        public string TreatmentPlan { get; set; }
        public DateTime RecordDate { get; set; }
        public string DoctorId { get; set; }

        public MedicalRecord(Patient patient)
        {
            Patient = patient;
            PatientId = patient.PatientId;
        }

        public MedicalRecord()
        {

        }
    }
}
