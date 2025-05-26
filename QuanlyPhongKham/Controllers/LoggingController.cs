using QuanlyPhongKham.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;

namespace QuanlyPhongKham.Controllers
{
    class LoggingController
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
    }
}
