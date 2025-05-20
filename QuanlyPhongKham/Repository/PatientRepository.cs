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
                                        (PatientId, FullName, Email, Gender, PhoneNumber, Dob, GuardianId) 
                                        VALUES 
                                        (@PatientId, @FullName, @Email, @Gender, @PhoneNumber, @Dob, @GuardianId)";

                    using (var cmd = new SQLiteCommand(insertSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientId", patientId);
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Dob", dob);
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
                var patient = new Patient
                {
                    PatientId = Guid.Parse(reader["PatientId"].ToString()!),
                    Name = reader["FullName"].ToString()!,
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
                                            FullName = @FullName,
                                            Email = @Email,
                                            Gender = @Gender,
                                            PhoneNumber = @PhoneNumber,
                                            Dob = @Dob,
                                            GuardianId = @GuardianId
                                        WHERE PatientId = @PatientId";

                    using (var cmd = new SQLiteCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@FullName", name);
                        cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Dob", dob);
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

        public List<Patient> GetAllPatients()
        {
            var list = new List<Patient>();

            using var conn = GetConnection();
            string query = "SELECT PatientId, FullName FROM Patients";

            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Patient
                {
                    PatientId = Guid.Parse(reader["PatientId"].ToString()),
                    Name = reader["FullName"].ToString()
                });
            }

            return list;
        }
    }
}
