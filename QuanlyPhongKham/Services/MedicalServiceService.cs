using QuanlyPhongKham.Repository;
using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Services
{
    public class MedicalServiceService
    {
        private readonly MedicalServiceRepository _repository;

        public MedicalServiceService()
        {
            _repository = new MedicalServiceRepository();
        }

        public decimal? LayGiaDichVu(string tenDichVu)
        {
            return _repository.LayGiaDichVuTheoTen(tenDichVu);
        }

        public async Task<List<MedicalService>> GetAllService()
        {
           return await _repository.GetAllService();
        }

        public async Task<bool> AddService(string servicename, decimal serviceprice)
        {
            if (await _repository.CheckServiceExists(servicename))
            {
                return false; // Dịch vụ đã tồn tại
            }
            return await _repository.AddService(servicename, serviceprice);
        }

        public async Task<bool> DeleteService(string serviceId)
        {
            return await _repository.DeleteService(serviceId);
        }
        public async Task<bool> UpdateServicePrice(string serviceName, decimal servicePrice)
        {
            return await _repository.UpdateServicePrice(serviceName, servicePrice);
        }

        public async Task<List<MedicalService>> SortServiceByCount()
        {
            return await _repository.SortServiceByCount();
        }

        public async Task<List<(string ServiceName, decimal TotalRevenue)>> GetTopServiceRevenueAsync()
        {
            return await _repository.GetTopServiceRevenueAsync();
        }
    }
        
}