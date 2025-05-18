using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{

    public class Invoice
    {
        public int InvoiceId { get; set; }

        public Guid PatientId { get; set; }

        //public string PatientName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<InvoiceDetail> Details { get; set; } = [];
    }


}
