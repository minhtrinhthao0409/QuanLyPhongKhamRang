using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanlyPhongKham.Models;
using QuanlyPhongKham.Services;
using System.Data.SQLite;

namespace QuanlyPhongKham.Controllers
{
    public class UserControllers
    {
        public UserService userService;
        private readonly string connectionString = "Data Source=QuanLyPhongKham.db;Version=3;";

        public UserControllers()
        {
            userService = new UserService();
        }
        //public async Task<int> CreateUser(string username, string password, string email)
        //{

        //    return await userService.CreateUserAsync(username, email, password);

        //}
        public async Task<bool> CreateAccount(string username, string password, string email, string fullName, string phone, int role)
        {
            if (role != 2 && role != 3)
                throw new ArgumentException("Chỉ được phép tạo tài khoản bác sĩ (2) hoặc thu ngân (3)");

            string userId = Guid.NewGuid().ToString();
            string insertUserQuery = @"INSERT INTO Users (Id, UserName, Password, Email, Role) 
                                       VALUES (@Id, @UserName, @Password, @Email, @Role)";

            using (var conn = new SQLiteConnection(connectionString))
            {
                await conn.OpenAsync();

                // 1. Chèn vào bảng Users
                using (var cmd = new SQLiteCommand(insertUserQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", userId);
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Role", role);
                    await cmd.ExecuteNonQueryAsync();
                }

                // 2. Nếu là bác sĩ
                if (role == 2)
                {
                    string doctorId = Guid.NewGuid().ToString();
                    string insertDoctorQuery = @"INSERT INTO Doctors (IdDoctor, IdUser, FullName, PhoneNumber, Email) 
                                                 VALUES (@IdDoctor, @IdUser, @FullName, @PhoneNumber, @Email)";
                    using (var cmd = new SQLiteCommand(insertDoctorQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdDoctor", doctorId);
                        cmd.Parameters.AddWithValue("@IdUser", userId);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }

                // 3. Nếu là thu ngân
                else if (role == 3)
                {
                    string cashierId = Guid.NewGuid().ToString();
                    string insertCashierQuery = @"INSERT INTO Cashiers (IdCashier, IdUser, FullName, PhoneNumber) 
                                                  VALUES (@IdCashier, @IdUser, @FullName, @PhoneNumber)";
                    using (var cmd = new SQLiteCommand(insertCashierQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCashier", cashierId);
                        cmd.Parameters.AddWithValue("@IdUser", userId);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }

            return true;
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
