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
                        cmd.Parameters.AddWithValue("@Gender", gender ? 1 : 0);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@DOB", dob.Date);
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
                string query = "SELECT PhoneNumber, FullName FROM Patients";

                using var cmd = new SQLiteCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    if (reader["PhoneNumber"] != DBNull.Value && reader["FullName"] != DBNull.Value)
                    {
                        patients.Add(new Patient
                        {
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


        public async Task<bool> UpdatePatientFromInputAsync(string name, string phone, string? email, string? newPhone, string? newEmail,
                                                            string? newGuardianName, string? newGuardianPhone, string? newGuardianEmail)
        {
            var foundPatients = await SearchPatientsAsync(name, phone, email);

            if (foundPatients.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bệnh nhân phù hợp.");
                return false;
            }

            if (foundPatients.Count > 1)
            {
                MessageBox.Show("Tìm thấy nhiều hơn 1 bệnh nhân. Vui lòng xác định rõ.");
                return false;
            }

            var patient = foundPatients[0];

            bool patientChanged =
                (newPhone ?? patient.PhoneNumber) != patient.PhoneNumber ||
                (newEmail ?? patient.Email) != patient.Email;

            bool guardianChanged = !string.IsNullOrWhiteSpace(newGuardianName)
                                || !string.IsNullOrWhiteSpace(newGuardianPhone)
                                || !string.IsNullOrWhiteSpace(newGuardianEmail);

            // Nếu có GuardianId thì cập nhật guardian
            if (guardianChanged && patient.GuardianId.HasValue)
            {
                await UpdateGuardianInfoAsync(patient.GuardianId.Value, newGuardianName, newGuardianPhone, newGuardianEmail);
            }

            // Nếu không có GuardianId nhưng người dùng nhập thông tin mới của guardian ⇒ bỏ qua cập nhật guardian, vẫn tiếp tục update bệnh nhân
            // Nếu không có thay đổi gì thì bỏ qua toàn bộ
            if (!patientChanged && (!patient.GuardianId.HasValue || !guardianChanged))
            {
                MessageBox.Show("Không có thay đổi nào để cập nhật.");
                return false;
            }

            int updatedRows = await UpdatePatientAsync(
                patientId: Guid.Parse(patient.PatientId),
                name: patient.Name,
                gender: patient.Gender,
                phoneNumber: newPhone ?? patient.PhoneNumber,
                email: newEmail ?? patient.Email,
                dob: patient.DOB,
                guardianId: patient.GuardianId // vẫn giữ nguyên ID hiện có (có thể null)
            );

            return updatedRows > 0;
        }




        public async Task<bool> UpdateGuardianInfoAsync(Guid guardianId, string? newName, string? newPhone, string? newEmail)
        {
            using var conn = await GetConnectionAsync();

            var query = new StringBuilder();
            var parameters = new List<SQLiteParameter>();
            var setClauses = new List<string>();

            if (!string.IsNullOrWhiteSpace(newName))
            {
                setClauses.Add("FullName = @FullName");
                parameters.Add(new SQLiteParameter("@FullName", newName));
            }

            if (!string.IsNullOrWhiteSpace(newPhone))
            {
                setClauses.Add("PhoneNumber = @PhoneNumber");
                parameters.Add(new SQLiteParameter("@PhoneNumber", newPhone));
            }

            if (!string.IsNullOrWhiteSpace(newEmail))
            {
                setClauses.Add("Email = @Email");
                parameters.Add(new SQLiteParameter("@Email", newEmail));
            }

            if (!setClauses.Any())
                return false; 

            query.Append("UPDATE Guardians SET ");
            query.Append(string.Join(", ", setClauses));
            query.Append(" WHERE GuardianId = @GuardianId");
            parameters.Add(new SQLiteParameter("@GuardianId", guardianId.ToString()));

            using var cmd = new SQLiteCommand(query.ToString(), conn);
            cmd.Parameters.AddRange(parameters.ToArray());

            int affected = await cmd.ExecuteNonQueryAsync();
            return affected > 0;
        }








    }





}

