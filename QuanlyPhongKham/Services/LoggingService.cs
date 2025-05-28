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
using System.Threading;

namespace QuanlyPhongKham.Services
{
    public class LoggingService
    {
        private readonly LoggingRepository _loggingRepository;
        private readonly UserRepository _userRepository;
        public LoggingService()
        {
            _loggingRepository = new LoggingRepository();
            _userRepository = new UserRepository();
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


        public async Task<List<(string username, DateTime logOutTime)>> GetUserLogOutBefore17Async(string username)
        {
            // Kiểm tra username hợp lệ
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username không được để trống.");
            }

            // Lấy tháng và năm hiện tại
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;
            int currentYear = now.Year;

            // Lấy tất cả bản ghi đăng xuất
            var loggings = await _loggingRepository.GetAllLoggingsAsync();
            var result = new List<(string username, DateTime logOutTime)>();

            // Duyệt từng bản ghi
            foreach (var log in loggings)
            {
                // Kiểm tra bản ghi hợp lệ
                if (log.UserName == username &&
                    log.Content != null && log.Content.Contains("Đăng xuất") &&
                    DateTime.TryParse(log.DateTime, out DateTime logOutTime) &&
                    logOutTime.Hour < 17 &&
                    logOutTime.Month == currentMonth &&
                    logOutTime.Year == currentYear)
                {
                    result.Add((username, logOutTime));
                }
            }

            return result;
        }

        public async Task<List<(string username, int logOutCount)>> GetUsersLogOutCountBefore17Async()
        {
            // Lấy tháng và năm hiện tại
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;
            int currentYear = now.Year;

            // Lấy tất cả bản ghi đăng xuất
            var loggings = await _loggingRepository.GetAllLoggingsAsync();
            var userLogOutCounts = new Dictionary<string, int>();

            // Đếm số lần đăng xuất trước 17h cho mỗi username
            foreach (var log in loggings)
            {
                if (log.UserName != null &&
                    log.Content != null && log.Content.Contains("Đăng xuất") &&
                    DateTime.TryParse(log.DateTime, out DateTime logOutTime) &&
                    logOutTime.Hour < 17 &&
                    logOutTime.Month == currentMonth &&
                    logOutTime.Year == currentYear)
                {
                    // Tăng số lần đăng xuất cho username
                    if (userLogOutCounts.ContainsKey(log.UserName))
                    {
                        userLogOutCounts[log.UserName]++;
                    }
                    else
                    {
                        userLogOutCounts[log.UserName] = 1;
                    }
                }
            }

            // Chuyển dictionary thành danh sách kết quả
            var result = new List<(string username, int logOutCount)>();
            foreach (var pair in userLogOutCounts)
            {
                result.Add((pair.Key, pair.Value));
            }

            return result;
        }

    }
}
