using MySql.Data.MySqlClient;
using System;

namespace KinowySystemRezerwacji.service.model
{
    /// <summary>
    /// Klasa reprezentująca encję rezerwacji z bazy danych.
    /// </summary>
    internal class RezerwacjaEntity
    {
        /// <summary>
        /// Id rezerwacji.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Id seansu.
        /// </summary>
        internal int IdSeansu { get; set; }

        /// <summary>
        /// Id użytkownika.
        /// </summary>
        internal int IdUzytkownika { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal RezerwacjaEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            IdSeansu = (int)reader["id_seansu"];
            IdUzytkownika = (int)reader["id_uzytkownika"];
        }
    }
}
