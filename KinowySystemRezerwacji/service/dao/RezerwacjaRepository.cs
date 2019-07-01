using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinowySystemRezerwacji.service.model;

namespace KinowySystemRezerwacji.service.dao
{
    /// <summary>
    /// Repozytorium rezerwacji.
    /// </summary>
    internal class RezerwacjaRepository
    {
        /// <summary>
        /// Metoda wyciągająca z bazy danych dane rezerwacji wykonancych na dany seans.
        /// </summary>
        /// <param name="showingId">ID wybranego seansu</param>
        /// <returns>Dane rezerwacji</returns>
        internal List<RezerwacjaEntity> FindAllBySeansId(int idSeansu)
        {
            throw new NotImplementedException();
        }
    }
}
