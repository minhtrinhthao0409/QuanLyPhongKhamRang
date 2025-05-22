using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Services
{
    public class MedicalRecordService
    {
        private readonly MedicalRecordRepository _repository;
        public MedicalRecordService()
        {
            _repository = new MedicalRecordRepository();
        }

        public async Task<int> CreateMedicalRecordAsync(MedicalRecord record, string doctorId)
        {
            return await _repository.CreateMedicalRecordAsync(
                record.PatientId,
                record.Symptoms,
                record.Diagnosis,
                record.TreatmentPlan,
                doctorId
            );
        }
        public async Task<List<MedicalRecord>> GetMedicalRecordsByDoctorAsync(string doctorId)
        {
            return await _repository.GetMedicalRecordsByDoctorAsync(doctorId);
        }
    }
}
