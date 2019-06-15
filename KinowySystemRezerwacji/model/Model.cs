using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinowySystemRezerwacji.dto;

namespace KinowySystemRezerwacji.model
{
    /// <summary>
    /// Logika biznesowa aplikacji.
    /// </summary>
    internal class Model
    {
        /// <summary>
        /// Event reprezentujący prostą odpowiedź informującą o suckesie danej operacji.
        /// </summary>
        internal event Action<bool, string> BasicResponse;

        /// <summary>
        /// Metoda rejestrująca w bazie dnaych nowego użytkownika.
        /// </summary>
        /// <param name="request">Dane dotyczące nowego użytkownika</param>
        internal void Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda logująca użytkownika.
        /// </summary>
        /// <param name="username">Nazwa użytkownika</param>
        /// <param name="hashedPassword">Zahashowane hasło</param>
        internal void LogIn(string username, string hashedPassword)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda wylogowywująca użytkownika.
        /// </summary>
        internal void LogOut()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda zwracająca listę wcześniejszych rezerwacji.
        /// </summary>
        /// <returns>Informacje o wcześniejszych rezerwacjach</returns>
        internal BookingResponse[] GetBookings()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda zwracająca listę dostępnych seansów.
        /// </summary>
        /// <returns>Informacje o dostępnych seansach</returns>
        internal ShowingResponse[] GetShowings()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda zwracająca listę miejsc na dany seans.
        /// </summary>
        /// <param name="showingId">ID wybranego seansu</param>
        /// <returns>Informacje o miejscach na sali</returns>
        internal SeatToChooseResponse[] GetSeats(int showingId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda tworząca rezerwację dla zalogowanego użytkownika.
        /// </summary>
        /// <param name="request">Dane dotyczące wybranego seansu i miejsc</param>
        internal void BookSeats(BookSeatsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
