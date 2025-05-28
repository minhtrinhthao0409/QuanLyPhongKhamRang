using QuanlyPhongKham.Services;
using QuanlyPhongKham.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Controllers
{
    public class MedicalServiceController
    {
        private readonly MedicalServiceService _service;

        public MedicalServiceController()
        {
            _service = new MedicalServiceService();
        }

        public decimal? LayGiaDichVu(string tenDichVu)
        {
            return _service.LayGiaDichVu(tenDichVu);
        }
        public async Task<List<MedicalService>> GetAllService()
        {
            return await _service.GetAllService();
        }
        public async Task<bool> AddService(string servicename, decimal serviceprice)
        {
            return await _service.AddService(servicename, serviceprice);
        }

        public async Task<bool> DeleteService(string serviceId)
        {
            return await _service.DeleteService(serviceId);
        }

        public async Task<bool> UpdateServicePrice(string serviceName, decimal servicePrice)
        {
            return await _service.UpdateServicePrice(serviceName, servicePrice);
        }
        public async Task<List<MedicalService>> SortServiceByCount()
        {
            return await _service.SortServiceByCount();
        }

        public async Task<List<(string ServiceName, decimal TotalRevenue)>> GetTopServiceRevenueAsync()
        {
            return await _service.GetTopServiceRevenueAsync();
        }
    }
}
