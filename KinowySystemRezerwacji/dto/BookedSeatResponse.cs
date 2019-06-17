using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.dto
{
    /// <summary>
    /// Struktura reprezentująca miejsce zarezerwowane już przez użytkownika.
    /// </summary>
    internal class BookedSeatResponse
    {
        /// <summary>
        /// Numer miejsca.
        /// </summary>
        internal int PosX { get; set; }

        /// <summary>
        /// Rząd miejsca.
        /// </summary>
        internal int PosY { get; set; }
    }
}
