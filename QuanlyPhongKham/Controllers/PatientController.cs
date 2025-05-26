using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Controllers
{
    public class PatientController
    {
        private readonly PatientService _patientService;
        public PatientController()
        {
            _patientService = new PatientService();
        }
        public PatientController(PatientService service)
        {
            _patientService = service;
        }
        public async Task<string> AddNewPatientAsync(string name, bool gender, string phone, string email, DateTime dob, Guid? guardianId = null)
        {
            if (string.IsNullOrWhiteSpace(name)) return "Tên không được rỗng";
            if (string.IsNullOrWhiteSpace(phone)) return "Số điện thoại không được rỗng";

            var id = Guid.NewGuid();
            var result = await _patientService.CreatePatientAsync(id, name, gender, phone, email, dob, guardianId);
            return result > 0 ? "Thêm bệnh nhân thành công" : "Thêm thất bại";
        }

        public Task<List<Patient>> SearchPatientsAsync(string name, string phone, string email)
        {
            return _patientService.SearchPatientsAsync(name, phone, email);
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            return await _patientService.GetAllPatientsAsync();
        }

        public async Task<bool> UpdatePatientAsync(string patientId, string name, bool gender, string phoneNumber, string email, DateTime dob, string? guardianId = null, string? guardianName = null)
        {
            return await _patientService.UpdatePatientAsync(patientId, name, gender, phoneNumber, email, dob, guardianId, guardianName);
        }


    }
}
