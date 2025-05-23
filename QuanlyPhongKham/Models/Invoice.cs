using QuanlyPhongKham.Models;
using System.Collections.Generic;
using System;

public class Invoice
{
    public int InvoiceId { get; set; }
    public string PatientId { get; set; }
    public string? PatientName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public decimal TotalAmount { get; set; }
    public decimal PaidAmount { get; set; }  
    public string Status { get; set; } = "Chưa thanh toán";

    public List<InvoiceDetail> Details { get; set; } = [];

    public Invoice()
    {
        PatientId = Guid.NewGuid().ToString();
    }
}