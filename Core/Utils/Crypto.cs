using System.Security.Cryptography;
using System.Text;

namespace Server
{
    public static class Crypto
    {
        private static readonly string emailSecret;

        static Crypto()
        {
            emailSecret = Environment.GetEnvironmentVariable("TOS_EMAIL_SECRET");

            if (string.IsNullOrEmpty(emailSecret))            
                throw new InvalidOperationException("Chave secreta do email (TOS_EMAIL_SECRET) não está configurada.");
        }

        public static string HashUsername(string username)
        {
            using (var sha1 = SHA1.Create())
            {
                var hashedBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(username));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static string EncryptEmail(string email)
        {
            if (string.IsNullOrEmpty(emailSecret))
                throw new InvalidOperationException("Chave secreta do email não está configurada.");

            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(emailSecret);
                aesAlg.GenerateIV();

                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);

                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(email);
                    }

                    var encrypted = msEncrypt.ToArray();
                    return Convert.ToBase64String(encrypted);
                }
            }
        }

        public static string DecryptEmail(string encryptedEmail)
        {
            if (string.IsNullOrEmpty(emailSecret))
                throw new InvalidOperationException("Chave secreta do email não está configurada.");

            var fullCipher = Convert.FromBase64String(encryptedEmail);

            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(emailSecret);

                var iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;

                var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (var msDecrypt = new MemoryStream(fullCipher, iv.Length, fullCipher.Length - iv.Length))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
