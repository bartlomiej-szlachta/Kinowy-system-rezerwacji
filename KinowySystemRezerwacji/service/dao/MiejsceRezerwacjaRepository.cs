using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinowySystemRezerwacji.service.model;

namespace KinowySystemRezerwacji.service.dao
{
    /// <summary>
    /// Repozytorium miejsc-rezerwacji.
    /// </summary>
    internal class MiejsceRezerwacjaRepository
    {
        /// <summary>
        /// Metoda wyciągająca z bazy danych dane miejsc-rezerwacji dotyczących danej rezerwacji.
        /// </summary>
        /// <param name="idRezerwacji">ID rezerwacji</param>
        /// <returns>Dane miejsc-rezerwacji</returns>
        internal List<MiejsceRezerwacjaEntity> FindAllByRezerwacjaId(int idRezerwacji)
        {
            throw new NotImplementedException();
        }
    }
}
