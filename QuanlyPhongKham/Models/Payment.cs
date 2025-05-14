using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Models
{
    public class Payment
    {
        
        public string PaymentMethod { get ; set ; }
        public float Total { get; set ; }
        public float Balance { get; set; }
        public string Status { get; set; } = "pending";
        public string TransactionID { get; set; }
        public int AppointmentID { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;



    }
}
