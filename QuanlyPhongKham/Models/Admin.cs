namespace QuanlyPhongKham.Models
{
    public class Admin : User
    {
        public Admin(string userName, string password, string email) : base(userName, password, email, UserRole.Admin)
        {

        }

        //public Admin() { }

    }
}
