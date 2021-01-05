using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GYM_GetYourMuscles.Services.Services
{
    public static class PasswordService
    {
        private static readonly int _keySize = 32;
        private static readonly int _saltSize = 32;
        private static readonly int _iteration = 32;

        public static string GeneratePassword(string password)
        {
            using var config = new Rfc2898DeriveBytes(password, _saltSize, _iteration, HashAlgorithmName.SHA256);
            var key = Convert.ToBase64String(config.GetBytes(_keySize));
            var salt = Convert.ToBase64String(config.Salt);
            return $"{Convert.ToBase64String(Encoding.ASCII.GetBytes(_iteration.ToString()))}.{salt}.{key}";
        }

        public static bool PasswordIsCorrect(string salt, string hashedPassword, string password)
        {
            using var config = new Rfc2898DeriveBytes(password, Convert.FromBase64String(salt), _iteration, HashAlgorithmName.SHA256);
            var key = Convert.ToBase64String(config.GetBytes(_keySize));

            return key.Equals(hashedPassword);
        }
    }
}
