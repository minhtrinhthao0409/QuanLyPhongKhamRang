using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Services;

namespace QuanlyPhongKham.Controllers
{
    public class UserControllers
    {
        public UserService userService;

        public UserControllers() { 
            userService = new UserService();
        }
        public async Task<int> CreateUser(string username , string password, string email)
        {

              return await userService.CreateUserAsync(username, email, password);

        }
        public async Task<bool> Login(string username, string password)
        {
            return await userService.VerifyUserAsync(username, password);
        }
        public async Task<String> GetPasswordByEmail(string email)
        {
            return await userService.GetPasswordByEmail(email);
        }


    }
}
