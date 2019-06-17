using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.dto
{
    /// <summary>
    /// Struktura reprezentująca miejsce do wybrania.
    /// </summary>
    internal class SeatToChooseResponse
    {
        /// <summary>
        /// Id miejsca.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Numer miejsca.
        /// </summary>
        internal int PosX { get; set; }

        /// <summary>
        /// Rząd miejsca.
        /// </summary>
        internal int PosY { get; set; }

        /// <summary>
        /// Informacja o tym, czy miejsce jest dostępne do zarezerwowania.
        /// </summary>
        internal bool Available { get; set; }
    }
}
