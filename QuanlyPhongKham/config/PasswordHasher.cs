using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace QuanlyPhongKham
{
    public class PasswordHasher
    {
        //    public static string HashPassword(string password)
        //    {
        //        SHA256 sha256Hash = SHA256.Create();
        //        // Convert the input string to a byte array and compute the hash.
        //        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

        //        // Convert the byte array to a hexadecimal string.
        //        StringBuilder builder = new StringBuilder();
        //        for (int i = 0; i < bytes.Length; i++)
        //        {
        //            builder.Append(bytes[i].ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }

        //    public static bool VerifyPassword(string inputPassword, string storedHash)
        //    {
        //        // Hash the input password.
        //        string hashOfInput = HashPassword(inputPassword);

        //        // Compare the hashed input password with the stored hash.
        //        return hashOfInput.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        //    }
        //}


        //private static readonly byte[] Key = Convert.FromBase64String("dGhpcy1pcy1hLXNlY3JldC1rZXktMTIzNDU2Nzg5MA=="); // Khóa 32 byte (256 bit)
        //private static readonly byte[] IV = Convert.FromBase64String("MTIzNDU2Nzg5MDEyMzQ1Ng==");        // Vector khởi tạo 16 byte (128 bit)
        private static readonly byte[] Key = new byte[32] 
            {
                  0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
                  0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F,
                  0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17,
                  0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F
            };

        private static readonly byte[] IV = new byte[16] // 16 byte (128 bit)
        {
                  0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07,
                 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F
        };
        public static string HashPassword(string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(password);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }

        public static string DecryptPassword(string encryptedPassword)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(encryptedPassword)))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static bool VerifyPassword(string inputPassword, string storedEncryptedPassword)
        {
            if (string.IsNullOrWhiteSpace(inputPassword) || string.IsNullOrWhiteSpace(storedEncryptedPassword))
                return false;

            try
            {
                string decryptedPassword = DecryptPassword(storedEncryptedPassword);
                return inputPassword.Equals(decryptedPassword, StringComparison.Ordinal);
            }
            catch (Exception)
            {
                return false; // Lỗi giải mã, coi như không khớp
            }
        }
    }
}