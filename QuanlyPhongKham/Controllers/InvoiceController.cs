using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Controllers
{
    public class InvoiceController
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceController()
        {
            _invoiceService = new InvoiceService();
        }

        public async Task CreateInvoiceAsync(Invoice invoice)
        {
            if (invoice == null || invoice.Details.Count == 0)
                throw new ArgumentException("Hóa đơn không hợp lệ.");

            await _invoiceService.CreateInvoiceAsync(invoice);
        }
    }
}
