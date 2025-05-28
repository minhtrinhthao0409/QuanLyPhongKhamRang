using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;

namespace QuanlyPhongKham.Controllers
{
    public class LoggingController
    {
        LoggingService _loggingService;
        public LoggingController()
        {
            _loggingService = new LoggingService();
        }
        public async Task<bool> AddLoggingAsync(string userId, string userName, string content)
        {
            return await _loggingService.AddLoggingAsync(userId, userName, content);
        }
        public async Task<List<Logging>> GetAllLoggingsAsync()
        {
            return await _loggingService.GetAllLoggingsAsync();
        }

        public async Task<List<(string username, DateTime logOutTime)>> GetUserLogOutBefore17Async(string username)
        {
            return await _loggingService.GetUserLogOutBefore17Async(username);
        }
        public async Task<List<(string username, int logOutCount)>> GetUsersLogOutCountBefore17Async()
        {
            return await _loggingService.GetUsersLogOutCountBefore17Async();
        }
    }
}
