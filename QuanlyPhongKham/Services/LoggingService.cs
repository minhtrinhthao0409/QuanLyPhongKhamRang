using QuanlyPhongKham.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Repository;
using System.Security.Permissions;

namespace QuanlyPhongKham.Services
{
    public class LoggingService
    {
        private readonly LoggingRepository _loggingRepository;
        public LoggingService()
        {
            _loggingRepository = new LoggingRepository();
        }

        public async Task<bool> AddLoggingAsync(string userId, string userName, string content)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(content))
                throw new ArgumentException("UserID, UserName and Content cannot be null or empty.");
            return await _loggingRepository.AddLoggingAsync(userId, userName, content);
        }

        public async Task<List<Logging>> GetAllLoggingsAsync()
        {
            return await _loggingRepository.GetAllLoggingsAsync();
        }
    }
}
