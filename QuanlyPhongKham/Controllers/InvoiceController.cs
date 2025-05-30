﻿using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
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

        public async Task<List<Invoice>> SearchInvoicesAsync(string phoneNo, DateTime startDate, DateTime endDate)
        {
            return await _invoiceService.SearchInvoicesAsync(phoneNo, startDate, endDate);
        }

        public async Task<List<InvoiceDetail>> GetInvoiceDetailsAsync(int invoiceId)
        {
            return await _invoiceService.GetInvoiceDetailsAsync(invoiceId);
        }

        public async Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate)
        {
            return await _invoiceService.GetTotalRevenueAsync(startDate, endDate);
        }
        public async Task<List<Invoice>> GetInvoiceByTime(DateTime startDate, DateTime endDate)
        {
            return await _invoiceService.GetInvoiceByTime(startDate, endDate);
        }
        public async Task UpdateInvoiceStatusAsync(int invoiceId)
        {
            await _invoiceService.UpdateInvoiceStatusAsync(invoiceId);
        }
    }
}
