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
                                        (PatientId, Name, Email, Gender, PhoneNumber, DOB, GuardianId) 
                                        VALUES 
                                        (@PatientId, @Name, @Email, @Gender, @PhoneNumber, @DOB, @GuardianId)";

                    using (var cmd = new SQLiteCommand(insertSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientId", patientId);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@DOB", dob);
                        cmd.Parameters.AddWithValue("@GuardianId", guardianId as object ?? DBNull.Value);

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
                query.Append(" AND Name LIKE @Name");

            if (!string.IsNullOrWhiteSpace(phone))
                query.Append(" AND PhoneNumber = @PhoneNumber");

            if (!string.IsNullOrWhiteSpace(email))
                query.Append(" AND Email LIKE @Email");

            using var command = new SQLiteCommand(query.ToString(), connection);

            if (!string.IsNullOrWhiteSpace(name))
                command.Parameters.AddWithValue("@Name", $"%{name}%");

            if (!string.IsNullOrWhiteSpace(phone))
                command.Parameters.AddWithValue("@PhoneNumber", phone);

            if (!string.IsNullOrWhiteSpace(email))
                command.Parameters.AddWithValue("@Email", $"%{email}%");

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var patient = new Patient
                {
                    PatientId = reader["PatientId"].ToString(),
                    Name = reader["Name"].ToString()!,
                    PhoneNumber = reader["PhoneNumber"].ToString()!,
                    Email = reader["Email"].ToString()!,
                    Gender = Convert.ToBoolean(reader["Gender"]),
                    DOB = Convert.ToDateTime(reader["Dob"]),
                    GuardianId = reader["GuardianId"] == DBNull.Value
                        ? null
                        : Guid.Parse(reader["GuardianId"].ToString()!)
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
                                            Name = @Name,
                                            Email = @Email,
                                            Gender = @Gender,
                                            PhoneNumber = @PhoneNumber,
                                            DOB = @DOB,
                                            GuardianId = @GuardianId
                                        WHERE PatientId = @PatientId";

                    using (var cmd = new SQLiteCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
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
                string query = "SELECT PatientId, Name FROM Patients";

                using var cmd = new SQLiteCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    if (reader["PatientId"] != DBNull.Value && reader["Name"] != DBNull.Value)
                    {
                        patients.Add(new Patient
                        {
                            PatientId = reader["PatientId"].ToString(),
                            Name = reader["Name"].ToString()
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
    }
}
