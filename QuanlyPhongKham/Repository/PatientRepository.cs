using QuanlyPhongKham.config;
using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanlyPhongKham.Repository
{
    public class PatientRepository(string connectionString = null) : BaseRepository(connectionString)
    {
        
        public async Task<int> CreatePatientAsync(Guid patientId, string name, bool gender, string phoneNumber, string email, DateTime dob, Guid? guardianId = null)
        {
            
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên bệnh nhân không được rỗng.", nameof(name));
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Số điện thoại không được rỗng.", nameof(phoneNumber));
            
                


            int affectedRows = 0;

            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertSql = @"
                                        INSERT INTO Patients 
                                        (PatientId, FullName, Email, Gender, PhoneNumber, DOB, GuardianId) 
                                        VALUES 
                                        (@PatientId, @FullName, @Email, @Gender, @PhoneNumber, @DOB, @GuardianId)";

                    using (var cmd = new SQLiteCommand(insertSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientId", patientId.ToString());
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        cmd.Parameters.AddWithValue("@DOB", dob.Date);
                        cmd.Parameters.AddWithValue("@GuardianId", guardianId.ToString() as object ?? DBNull.Value);


                        affectedRows = await cmd.ExecuteNonQueryAsync();
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi tạo hồ sơ bệnh nhân.", ex);
                }
            }
            return affectedRows;
        }

        public async Task<List<Patient>> SearchPatientsAsync(string name, string phone, string email)
        {
            var patients = new List<Patient>();

            using var connection = await GetConnectionAsync();

            var query = new StringBuilder(@"
                                            SELECT p.*,  g.FullName AS GuardianName
                                            FROM Patients p
                                            LEFT JOIN Guardians g ON p.GuardianId = g.GuardianId
                                            WHERE 1=1 ");

            if (!string.IsNullOrWhiteSpace(name))
                query.Append(" AND p.FullName LIKE @FullName");

            if (!string.IsNullOrWhiteSpace(phone))
                query.Append(" AND p.PhoneNumber = @PhoneNumber");

            if (!string.IsNullOrWhiteSpace(email))
                query.Append(" AND p.Email LIKE @Email");

            using var command = new SQLiteCommand(query.ToString(), connection);


            if (!string.IsNullOrWhiteSpace(name))
                command.Parameters.AddWithValue("@FullName", $"%{name}%");

            if (!string.IsNullOrWhiteSpace(phone))
                command.Parameters.AddWithValue("@PhoneNumber", phone);

            if (!string.IsNullOrWhiteSpace(email))
                command.Parameters.AddWithValue("@Email", $"%{email}%");

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Guid? guardianId = null;

                // Xử lý GuardianId an toàn với TryParse
                if (reader["GuardianId"] != DBNull.Value)
                {
                    string rawGuardianId = reader["GuardianId"].ToString();
                    if (!string.IsNullOrWhiteSpace(rawGuardianId) && Guid.TryParse(rawGuardianId, out var parsedGuid))
                    {
                        guardianId = parsedGuid;
                    }
                }

                var patient = new Patient
                {
                    PatientId = reader["PatientId"].ToString(),
                    Name = reader["FullName"].ToString()!,
                    PhoneNumber = reader["PhoneNumber"].ToString()!,
                    Email = reader["Email"].ToString()!,
                    Gender = Convert.ToBoolean(reader["Gender"]),
                    DOB = Convert.ToDateTime(reader["Dob"]).Date,
                    GuardianId = guardianId,
                    GuardianName = reader["GuardianName"] == DBNull.Value
                   ? null
                   : reader["GuardianName"].ToString()
                };

                patients.Add(patient);
            }

            return patients;
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            List<Patient> patients = new List<Patient>();

            try
            {
                using var connection = await GetConnectionAsync();
                string query = "SELECT PatientId, PhoneNumber, FullName FROM Patients";

                using var cmd = new SQLiteCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    if (reader["PhoneNumber"] != DBNull.Value && reader["FullName"] != DBNull.Value)
                    {
                        patients.Add(new Patient
                        {
                            PatientId = reader["PatientId"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Name = reader["FullName"].ToString()
                        });
                    }
                }
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Lỗi khi lấy danh sách bệnh nhân: " + ex.Message);
            }

            return patients;
        }

        public async Task<bool> UpdatePatientAsync(string patientId, string name, bool gender,string? phoneNumber, string? email, DateTime dob,
                                                    string? guardianId = null, string? guardianName = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên bệnh nhân không được rỗng.", nameof(name));
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Số điện thoại không được rỗng.", nameof(phoneNumber));

            using var connection = await GetConnectionAsync();
            using var transaction = (SQLiteTransaction)await connection.BeginTransactionAsync();

            try
            {
                int affectedRows = 0;

                // Cập nhật bệnh nhân
                string updatePatientSql = @"
                                            UPDATE Patients 
                                            SET 
                                                FullName = @FullName,
                                                Email = @Email,
                                                Gender = @Gender,
                                                PhoneNumber = @PhoneNumber,
                                                DOB = @DOB,
                                                GuardianId = @GuardianId
                                            WHERE PatientId = @PatientId";

                using (var patientCmd = new SQLiteCommand(updatePatientSql, connection, transaction))
                {
                    patientCmd.Parameters.AddWithValue("@FullName", name);
                    patientCmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email);
                    patientCmd.Parameters.AddWithValue("@Gender", gender ? 1 : 0);
                    patientCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    patientCmd.Parameters.AddWithValue("@DOB", dob.Date);
                    patientCmd.Parameters.AddWithValue("@GuardianId", string.IsNullOrWhiteSpace(guardianId) ? DBNull.Value : guardianId);
                    patientCmd.Parameters.AddWithValue("@PatientId", patientId);

                    affectedRows = await patientCmd.ExecuteNonQueryAsync();
                }

                // Cập nhật tên người giám hộ nếu có guardianId và tên
                if (!string.IsNullOrWhiteSpace(guardianId) && !string.IsNullOrWhiteSpace(guardianName))
                {
                    string updateGuardianSql = @"
                                                UPDATE Guardians
                                                SET FullName = @GuardianName
                                                WHERE GuardianId = @GuardianId";

                    using var guardianCmd = new SQLiteCommand(updateGuardianSql, connection, transaction);
                    guardianCmd.Parameters.AddWithValue("@GuardianName", guardianName);
                    guardianCmd.Parameters.AddWithValue("@GuardianId", guardianId);

                    await guardianCmd.ExecuteNonQueryAsync();
                }

                await transaction.CommitAsync();

                Console.WriteLine(affectedRows == 0
                    ? "Không có bản ghi nào được cập nhật. Dữ liệu có thể không thay đổi."
                    : "Cập nhật thành công.");

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine("Lỗi khi cập nhật thông tin bệnh nhân: " + ex.Message);
                throw new Exception("Lỗi khi cập nhật thông tin bệnh nhân.", ex);
            }
        }



        public async Task<int> CreateGuardianAsync(Guid guardianId, string name, string phoneNumber, string email)
        {

            int affectedRows = 0;

            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertSql = @"
                INSERT INTO Guardians 
                (GuardianId, FullName, PhoneNumber, Email)
                VALUES 
                (@GuardianId, @FullName, @PhoneNumber, @Email)";

                    using (var cmd = new SQLiteCommand(insertSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@GuardianId", guardianId.ToString());
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                        affectedRows = await cmd.ExecuteNonQueryAsync();
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi tạo người giám hộ.", ex);
                }
            }

            return affectedRows;
        }


    }
}

