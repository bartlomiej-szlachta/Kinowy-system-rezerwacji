using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.dto
{
    /// <summary>
    /// Struktura reprezentująca rezerwację.
    /// </summary>
    internal class BookingResponse
    {
        /// <summary>
        /// Nazwa filmu
        /// </summary>
        internal string FilmName { get; set; }

        /// <summary>
        /// Data i godzina seansu.
        /// </summary>
        internal DateTime DateTime { get; set; }

        /// <summary>
        /// Wybrane miejsca.
        /// </summary>
        internal BookedSeatResponse[] Seats { get; set; }
    }
}
