using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.service.dao
{
    /// <summary>
    /// Pomocnicza klasa zawierająca rezultat z bazy danych dotyczący jednego rekordu.
    /// </summary>
    /// <typeparam name="T">Obiekt reprezentujący uzyskiwaną encję</typeparam>
    internal class Optional<T>
    {
        /// <summary>
        /// Obiekt reprezentujący uzyskiwaną encję.
        /// </summary>
        internal T ResultObject { get; private set; }

        /// <summary>
        /// Informacja o sukcesie zapytania.
        /// </summary>
        internal bool Success { get; private set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="resultObject"></param>
        internal Optional(T resultObject)
        {
            ResultObject = resultObject;
            Success = !(resultObject == null);
        }

        /// <summary>
        /// Metoda zwracająca uzyskany obiekt lub rzucająca wyjątek w przypadku niepowodzenia zapytania.
        /// </summary>
        /// <param name="message">Wiadomość składowa wyjątku</param>
        /// <returns>Obiekt reprezentujący uzyskiwaną encję</returns>
        internal T OrElseThrow(string message)
        {
            if (!Success)
            {
                throw new Exception(message);
            }
            else
            {
                return ResultObject;
            }
        }
    }
}
