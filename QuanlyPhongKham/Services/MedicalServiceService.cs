using QuanlyPhongKham.Repository;
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
    }
}