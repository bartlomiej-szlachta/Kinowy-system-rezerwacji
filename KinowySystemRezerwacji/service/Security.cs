using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KinowySystemRezerwacji.service
{
    internal class Security
    {
        internal static string HashPassword(string plainPassword)
        {
            int iterations = 10000;

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(plainPassword, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string base64Hash = Convert.ToBase64String(hashBytes);

            return string.Format("$SZLACHTA$RUSIN$HASH$V1${0}${1}", iterations, base64Hash);
        }
    }
}
