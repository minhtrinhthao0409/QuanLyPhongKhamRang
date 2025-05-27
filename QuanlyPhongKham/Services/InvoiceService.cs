using QuanlyPhongKham.Models;
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
            if (invoice.TotalAmount <= 0)
                throw new Exception("Tổng tiền phải lớn hơn 0.");

            await _invoiceRepository.CreateInvoiceAsync(invoice);
        }
        public async Task<List<Invoice>> SearchInvoicesAsync(string phoneNo, DateTime startDate, DateTime endDate)
        {
            return await _invoiceRepository.SearchInvoicesAsync(phoneNo, startDate, endDate);
        }

        public async Task<List<InvoiceDetail>> GetInvoiceDetailsAsync(int invoiceId)
        {
            return await _invoiceRepository.GetInvoiceDetailsAsync(invoiceId);
        }
        public async Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate)
        {
            return await _invoiceRepository.GetTotalRevenueAsync(startDate, endDate);
        }

        public async Task<List<Invoice>> GetInvoiceByTime(DateTime startDate, DateTime endDate)
        {
            return await _invoiceRepository.GetInvoiceByTime(startDate, endDate);
        }
        public async Task<List<Invoice>> GetAllAsync()
        {
            return await GetInvoiceByTime(DateTime.MinValue, DateTime.MaxValue);
        }
        public async Task UpdateInvoiceStatusAsync(int invoiceId)
        {
            await _invoiceRepository.SetInvoiceAsPaidAsync(invoiceId);
        }
    }

}
