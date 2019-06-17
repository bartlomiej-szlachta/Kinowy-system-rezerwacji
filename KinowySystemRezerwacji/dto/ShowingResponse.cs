using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.dto
{
    /// <summary>
    /// Struktura reprezentująca seans do wyświetlenia.
    /// </summary>
    internal class ShowingResponse
    {
        /// <summary>
        /// Id seansu.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Data i godzina seansu.
        /// </summary>
        internal DateTime DateTime { get; set; }

        /// <summary>
        /// Nazwa filmu.
        /// </summary>
        internal string FilmName { get; set; }

        /// <summary>
        /// Czas trwania filmu.
        /// </summary>
        internal int FilmDuration { get; set; }

        /// <summary>
        /// Rok ukazania się filmu.
        /// </summary>
        internal int FilmYear { get; set; }
    }
}
