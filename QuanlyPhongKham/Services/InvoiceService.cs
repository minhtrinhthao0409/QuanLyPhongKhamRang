using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Services
{
    public class InvoiceService
    {
        private readonly InvoiceRepository _invoiceRepository;

        public InvoiceService()
        {
            _invoiceRepository = new InvoiceRepository();
        }

        public async Task CreateInvoiceAsync(Invoice invoice)
        {
            // Optional: kiểm tra nghiệp vụ như tổng tiền hợp lệ, dịch vụ còn hoạt động,...
            if (invoice.TotalAmount <= 0)
                throw new Exception("Tổng tiền phải lớn hơn 0.");

            await _invoiceRepository.CreateInvoiceAsync(invoice);
        }
        public async Task<List<Invoice>> SearchInvoicesAsync(string phoneNo, DateTime startDate, DateTime endDate)
        {
            return await _invoiceRepository.SearchInvoicesAsync(phoneNo, startDate, endDate);
        }
    }
}
