using MySql.Data.MySqlClient;

namespace KinowySystemRezerwacji.service.model
{
    /// <summary>
    /// Klasa reprezentująca encję filmu z bazy danych.
    /// </summary>
    internal class FilmEntity
    {
        /// <summary>
        /// Id filmu.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Nazwa filmu.
        /// </summary>
        internal string Nazwa { get; set; }

        /// <summary>
        /// Czas trwania filmu (w minutach).
        /// </summary>
        internal int CzasTrwania { get; set; }

        /// <summary>
        /// Ocena filmu (od 0 do 5).
        /// </summary>
        internal float Ocena { get; set; }

        /// <summary>
        /// Rok premiery filmu.
        /// </summary>
        internal int RokPremiery { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal FilmEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            Nazwa = (string)reader["nazwa"];
            CzasTrwania = (int)reader["czas_trwania"];
            Ocena = (float)reader["ocena"];
            RokPremiery = (int)reader["rok_premiery"];
        }
    }
}
