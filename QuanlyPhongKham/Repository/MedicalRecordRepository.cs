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
        public async Task<int> CreateMedicalRecordAsync(Guid patientId, string patientName, string symtoms, string diagnosis, string treatmentPlan)
        {
            if (string.IsNullOrWhiteSpace(patientName))
                throw new ArgumentException("Tên bệnh nhân không được rỗng.", nameof(patientName));

            if (string.IsNullOrWhiteSpace(symtoms))
                throw new ArgumentException("Triệu chứng không được rỗng.", nameof(symtoms));

            DateTime recordDate = DateTime.Now;

            int affectedRows = 0;

            using (var connection = await GetConnectionAsync())
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertSql = @"
                INSERT INTO MedicalRecords 
                (PatientId, PatientName, Symtoms, Diagnosis, TreatmentPlan, RecordDate) 
                VALUES 
                (@PatientId, @PatientName, @Symtoms, @Diagnosis, @TreatmentPlan, @RecordDate)";

                    using (var cmd = new SQLiteCommand(insertSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientId", patientId);
                        cmd.Parameters.AddWithValue("@PatientName", patientName);
                        cmd.Parameters.AddWithValue("@Symtoms", symtoms);
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

        public async Task<int> UpdateMedicalRecordAsync(int medRecId, string symtoms, string diagnosis, string treatmentPlan, DateTime recordDate)
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
                    Symtoms = @Symtoms,
                    Diagnosis = @Diagnosis,
                    TreatmentPlan = @TreatmentPlan,
                    RecordDate = @RecordDate
                WHERE MedRecId = @MedRecId";

                    using (var cmd = new SQLiteCommand(updateSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Symtoms", symtoms);
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

    }
}
   
