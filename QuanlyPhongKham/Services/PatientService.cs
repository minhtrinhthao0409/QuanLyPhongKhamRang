using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Services
{
    public class PatientService
    {
        private readonly PatientRepository _patientRepository;

        public PatientService()
        {
            _patientRepository = new PatientRepository();
        }

        public Task<int> CreatePatientAsync(Guid patientId, string name, bool gender, string phoneNumber, string email, DateTime dob, Guid? guardianId = null)
        {
            return _patientRepository.CreatePatientAsync(patientId, name, gender, phoneNumber, email, dob, guardianId);
        }

        public Task<List<Patient>> SearchPatientsAsync(string name, string phone, string email)
        {
            return _patientRepository.SearchPatientsAsync(name, phone, email);
        }
        public Task<bool> UpdatePatientAsync(string patientId, string name, bool gender, string? phoneNumber, string? email, DateTime dob, string? guardianId = null, string? guardianName = null)
        {
            return _patientRepository.UpdatePatientAsync(patientId, name, gender, phoneNumber, email, dob, guardianId, guardianName);
        }
        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            return await _patientRepository.GetAllPatientsAsync();
        }

        public Task<int> CreateGuardianAsync(Guid guardianId, string name, string phoneNumber, string email)
        {
            return _patientRepository.CreateGuardianAsync(guardianId, name, phoneNumber, email);
        }

        //public async Task<bool> UpdatePatientFromInputAsync(string name, string phone, string? email, string? newPhone, string? newEmail,
        //                                                    string? newGuardianName, string? newGuardianPhone, string? newGuardianEmail)
        //{
        //    return await _patientRepository.UpdatePatientFromInputAsync(name, phone, email, newPhone, newEmail, newGuardianName, newGuardianPhone, newGuardianEmail);
        //}



    }
}
