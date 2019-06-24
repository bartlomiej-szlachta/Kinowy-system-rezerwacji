using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KinowySystemRezerwacji.service
{
    /// <summary>
    /// Klasa odpowiedzialna za hashowanie haseł.
    /// </summary>
    internal class Security
    {
        /// <summary>
        /// Funkcja hashująca hasło.
        /// </summary>
        /// <param name="input">Hasło w postaci wpisanej przez użytkownika</param>
        /// <returns>Zahashowane hasło</returns>
        internal static string HashPassword(string input)
        {
            string salt = "SZLACHTARUSIN";
            byte[] data = new UnicodeEncoding().GetBytes(input + salt);
            var sha256Managed = new SHA256Managed();
            var computeHash = sha256Managed.ComputeHash(data);

            return ToHex(computeHash);
        }

        private static string ToHex(byte[] computeHash)
        {
            var hex = new StringBuilder();
            foreach (var b in computeHash)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }
    }
}
