using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.dto
{
    /// <summary>
    /// Struktura reprezentująca żądanie zarejestrowania użytkownika.
    /// </summary>
    internal class RegisterRequest
    {
        /// <summary>
        /// Nazwa użytkownika.
        /// </summary>
        internal string Username { get; set; }

        /// <summary>
        /// Hasło użytkownika, przekazane w 
        /// </summary>
        internal string HashedPassword { get; set; }

        /// <summary>
        /// Imię.
        /// </summary>
        internal string FirstName { get; set; }

        /// <summary>
        /// Nazwisko.
        /// </summary>
        internal string LastName { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        internal string Email { get; set; }

        /// <summary>
        /// Data urodzenia.
        /// </summary>
        internal DateTime Birthday { get; set; }
    }
}
