using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinowySystemRezerwacji.dto;

namespace KinowySystemRezerwacji
{
    /// <summary>
    /// Interfejs określający funkcjonalność widoku.
    /// </summary>
    internal interface IView
    {
        /// <summary>
        /// Event reprezentujący żądanie rejestracji nowego użytkownika.
        /// </summary>
        event Action<RegisterRequest> RequestRegister;

        /// <summary>
        /// Event reprezentujący żądanie logowania.
        /// </summary>
        event Action<string, string> RequestLogIn;

        /// <summary>
        /// Event reprezentujący żądanie wylogowania się z systemu.
        /// </summary>
        event Action RequestLogOut;

        /// <summary>
        /// Event reprezentujący żądanie wyświetlenia listy wcześniejszych rezerwacji.
        /// </summary>
        event Action RequestBookingsList;

        /// <summary>
        /// Event reprezentujący żądanie wyświetlenia listy dostępnych seansów.
        /// </summary>
        event Action<DateTime> RequestShowingsList;

        /// <summary>
        /// Event reprezentujący żądanie wyświetlenia listy miejsc na dany seans.
        /// </summary>
        event Action<int> RequestSeatsList;

        /// <summary>
        /// Event reprezentujący żądanie zarezerwowania miejsc na dany seans.
        /// </summary>
        event Action<BookSeatsRequest> RequestBookShowing;

        /// <summary>
        /// Metoda potwierdzająca zalogowanie użytkownika do systemu
        /// </summary>
        /// <param name="username">Nazwa zalogowanego użytkownika</param>
        void LoggingInCompleted(string username);

        /// <summary>
        /// Metoda wyświetlająca listę wcześniejszych rezerwacji.
        /// </summary>
        /// <param name="response">Zestaw obiektów zawierających dane dotyczące rezerwacji</param>
        void ShowBookingsList(BookingResponse[] response);

        /// <summary>
        /// Metoda wyświetlająca listę dostępnych seansów.
        /// </summary>
        /// <param name="response">Zestaw obiektów zawierających dane dotyczące seansów</param>
        void ShowShowingsList(ShowingResponse[] response);

        /// <summary>
        /// Metoda wyświetlająca listę dostępnych miejsc.
        /// </summary>
        /// <param name="response">Zestaw obiektów zawierających dane dotyczące miejsc</param>
        void ShowSeatsList(SeatToChooseResponse[] response);

        /// <summary>
        /// Metoda wyświetlająca komunikat na ekranie.
        /// </summary>
        /// <param name="success">Informacja o tym, czy komunikat jest pozytywny</param>
        /// <param name="message">Treść komunikatu</param>
        void ShowMessage(bool success, string message);
    }
}
