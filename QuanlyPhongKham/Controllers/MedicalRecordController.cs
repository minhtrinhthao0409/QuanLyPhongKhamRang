using QuanlyPhongKham.Models;
using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Controllers
{
    public class MedicalRecordController
    {
        public readonly MedicalRecordService _service;
        public MedicalRecordController()
        {
            _service = new MedicalRecordService();
        }

        public async Task<int> CreateMedicalRecordAsync(string patientId, string doctorId, string symptoms, string diagnosis, string treatmentPlan)
        {
            var record = new MedicalRecord
            {
                PatientId = patientId,
                Symptoms = symptoms,
                Diagnosis = diagnosis,
                TreatmentPlan = treatmentPlan
            };

            return await _service.CreateMedicalRecordAsync(record, doctorId);
        }
        public async Task<List<MedicalRecord>> GetMedicalRecordsByDoctorAsync(string doctorId)
        {
            return await _service.GetMedicalRecordsByDoctorAsync(doctorId);
        }

    }
}
