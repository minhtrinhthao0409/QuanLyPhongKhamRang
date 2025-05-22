using QuanlyPhongKham.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhongKham.Repository
{
    public class MedicalRecordRepository(string connectionString = null) : BaseRepository(connectionString)
    {
        public async Task<int> CreateMedicalRecordAsync(string patientId, string symptoms, string diagnosis, string treatmentPlan, string doctorId)
        {
            
            if (string.IsNullOrWhiteSpace(symptoms))
                throw new ArgumentException("Triệu chứng không được rỗng.", nameof(symptoms));

            DateTime recordDate = DateTime.Now;

            int affectedRows = 0;

            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertSql = @"
                        INSERT INTO MedicalRecords 
                        (Id, PatientId, DoctorId, Symptoms, Diagnosis, TreatmentPlan, RecordDate) 
                        VALUES 
                        (@Id, @PatientId, @DoctorId, @Symptoms, @Diagnosis, @TreatmentPlan, @RecordDate)";

                    using (var cmd = new SQLiteCommand(insertSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
                        cmd.Parameters.AddWithValue("@PatientId", patientId.ToString());
                        cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                        cmd.Parameters.AddWithValue("@Symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@Diagnosis", diagnosis ?? string.Empty);
                        cmd.Parameters.AddWithValue("@TreatmentPlan", treatmentPlan ?? string.Empty);
                        cmd.Parameters.AddWithValue("@RecordDate", recordDate);

                        affectedRows = await cmd.ExecuteNonQueryAsync();
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi tạo hồ sơ bệnh án.", ex);
                }
            }

            return affectedRows;
        }

        public async Task<int> UpdateMedicalRecordAsync(int medRecId, string symptoms, string diagnosis, string treatmentPlan, DateTime recordDate)
        {
            if (medRecId <= 0)
                throw new ArgumentException("ID hồ sơ bệnh án không hợp lệ.", nameof(medRecId));

            int affectedRows = 0;

            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string updateSql = @"
                        UPDATE MedicalRecords 
                        SET 
                            Symptoms = @Symptoms,
                            Diagnosis = @Diagnosis,
                            TreatmentPlan = @TreatmentPlan,
                            RecordDate = @RecordDate
                        WHERE MedRecId = @MedRecId";

                    using (var cmd = new SQLiteCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Symptoms", symptoms);
                        cmd.Parameters.AddWithValue("@Diagnosis", diagnosis ?? string.Empty);
                        cmd.Parameters.AddWithValue("@TreatmentPlan", treatmentPlan ?? string.Empty);
                        cmd.Parameters.AddWithValue("@RecordDate", recordDate);
                        cmd.Parameters.AddWithValue("@MedRecId", medRecId);

                        affectedRows = await cmd.ExecuteNonQueryAsync();
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Lỗi khi cập nhật hồ sơ bệnh án.", ex);
                }
            }

            return affectedRows;
        }
        public async Task<List<MedicalRecord>> GetMedicalRecordsByDoctorAsync(string doctorId)
        {
            var records = new List<MedicalRecord>();

            using (var connection = await GetConnectionAsync())
            {
                string query = @"
                SELECT 
                    mr.Id, mr.PatientId, mr.Symptoms, mr.Diagnosis, mr.TreatmentPlan, mr.RecordDate, mr.DoctorId,
                    p.FullName, p.DOB, p.Gender, p.PhoneNumber, p.Email
                FROM MedicalRecords mr
                JOIN Patients p ON mr.PatientId = p.PatientId
                WHERE mr.DoctorId = @DoctorId";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DoctorId", doctorId);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var patient = new Patient
                            {
                                PatientId = reader["PatientId"].ToString(),
                                Name = reader["FullName"].ToString(),
                                DOB = reader["DOB"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["DOB"]),
                                Gender = Convert.ToBoolean(reader["Gender"]),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Email = reader["Email"].ToString()
                            };

                            var record = new MedicalRecord(patient)
                            {
                                MedRecId = reader["Id"].ToString(),
                                Symptoms = reader["Symptoms"].ToString(),
                                Diagnosis = reader["Diagnosis"].ToString(),
                                TreatmentPlan = reader["TreatmentPlan"].ToString(),
                                RecordDate = Convert.ToDateTime(reader["RecordDate"]),
                                DoctorId = reader["DoctorId"].ToString()
                            };

                            records.Add(record);
                        }
                    }
                }
            }

            return records;
        }
    }
}
   
