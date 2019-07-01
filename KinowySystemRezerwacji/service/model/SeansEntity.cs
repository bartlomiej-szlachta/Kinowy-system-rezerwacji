using MySql.Data.MySqlClient;
using System;

namespace KinowySystemRezerwacji.service.model
{
    /// <summary>
    /// Klasa reprezentująca encję seansu z bazy danych.
    /// </summary>
    internal class SeansEntity
    {
        /// <summary>
        /// Id seansu.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Id filmu.
        /// </summary>
        internal int Id_filmu { get; set; }

        /// <summary>
        /// Data i godzina emisji filmu.
        /// </summary>
        internal DateTime Kiedy { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal SeansEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            Id_filmu = (int)reader["id_filmu"];
            Kiedy = (DateTime)reader["kiedy"];
        }
    }
}
