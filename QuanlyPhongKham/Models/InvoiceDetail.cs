namespace QuanlyPhongKham.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; } 
        public int InvoiceId { get; set; }

        public int ServiceId { get; set; }

        public string ServiceName { get; set; }

        public decimal Price { get; set; }


    }


}
