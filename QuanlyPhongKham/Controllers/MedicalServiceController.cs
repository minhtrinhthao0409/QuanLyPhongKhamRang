using QuanlyPhongKham.Services;

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
    }
}
