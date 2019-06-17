using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.dto
{
    /// <summary>
    /// Struktura reprezentująca żądanie zarezerwowania miejsc na dany seans.
    /// </summary>
    internal class BookSeatsRequest
    {
        /// <summary>
        /// ID wybranego seansu.
        /// </summary>
        internal int ShowingId { get; set; }

        /// <summary>
        /// ID wybranych miejsc.
        /// </summary>
        internal int[] SeatsIds { get; set; }
    }
}
