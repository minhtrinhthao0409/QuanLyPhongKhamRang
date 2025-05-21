using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                        cmd.Parameters.AddWithValue("@DOB", dob);
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

            var query = new StringBuilder("SELECT * FROM Patients WHERE 1=1");

            if (!string.IsNullOrWhiteSpace(name))
                query.Append(" AND FullName LIKE @FullName");

            if (!string.IsNullOrWhiteSpace(phone))
                query.Append(" AND PhoneNumber = @PhoneNumber");

            if (!string.IsNullOrWhiteSpace(email))
                query.Append(" AND Email LIKE @Email");

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
                    //PatientId = reader["PatientId"].ToString(),
                    Name = reader["FullName"].ToString()!,
                    PhoneNumber = reader["PhoneNumber"].ToString()!,
                    Email = reader["Email"].ToString()!,
                    Gender = Convert.ToBoolean(reader["Gender"]),
                    DOB = Convert.ToDateTime(reader["Dob"]),
                    GuardianId = guardianId
                };

                patients.Add(patient);
            }

            return patients;
        }

        public async Task<int> UpdatePatientAsync(Guid patientId, string name, bool gender, string phoneNumber, string email, DateTime dob, Guid? guardianId = null)
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
                    string updateSql = @"
                                        UPDATE Patients 
                                        SET 
                                            FullName = @FullName,
                                            Email = @Email,
                                            Gender = @Gender,
                                            PhoneNumber = @PhoneNumber,
                                            DOB = @DOB,
                                            GuardianId = @GuardianId
                                        WHERE PatientId = @PatientId";

                    using (var cmd = new SQLiteCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@GuardianId", guardianId as object ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PatientId", patientId);

                        affectedRows = await cmd.ExecuteNonQueryAsync();
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi cập nhật thông tin bệnh nhân.", ex);
                }
            }

            return affectedRows;
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            List<Patient> patients = new List<Patient>();

            try
            {
                using var connection = await GetConnectionAsync();
                string query = "SELECT PatientId, FullName FROM Patients";

                using var cmd = new SQLiteCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    if (reader["PatientId"] != DBNull.Value && reader["FullName"] != DBNull.Value)
                    {
                        patients.Add(new Patient
                        {
                            PatientId = reader["PatientId"].ToString(),
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

        public async Task<int> CreateGuardianAsync(Guid guardianId, string name, string phoneNumber, string email)
        {
            //if (string.IsNullOrWhiteSpace(name))
            //    throw new ArgumentException("Tên người giám hộ không được rỗng.", nameof(name));
            //if (string.IsNullOrWhiteSpace(phoneNumber))
            //    throw new ArgumentException("Số điện thoại người giám hộ không được rỗng.", nameof(phoneNumber));

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
                        cmd.Parameters.AddWithValue("@GuardianId",guardianId.ToString());
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
