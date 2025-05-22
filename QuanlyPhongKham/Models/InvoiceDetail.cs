using QuanlyPhongKham.Models;
using System.Collections.Generic;
using System;

namespace QuanlyPhongKham.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }   
        public int InvoiceId { get; set; }         
        public string ServiceName { get; set; }   
        public decimal UnitPrice { get; set; }  
        public int Quantity { get; set; }           
        public decimal TotalPrice => UnitPrice * Quantity; 
        public Invoice Invoice { get; set; }
    }
}
