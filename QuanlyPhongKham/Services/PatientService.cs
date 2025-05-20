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
        public Task<int> UpdatePatientAsync(Guid patientId, string name, bool gender, string phoneNumber, string email, DateTime dob, Guid? guardianId = null)
        {
            return _patientRepository.UpdatePatientAsync(patientId, name, gender, phoneNumber, email, dob, guardianId);
        }
        public List<Patient> GetAllPatients()
        {
            return _patientRepository.GetAllPatients();
        }
    }
}
