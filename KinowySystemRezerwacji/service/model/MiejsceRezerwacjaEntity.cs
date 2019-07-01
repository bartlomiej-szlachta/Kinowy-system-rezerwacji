using MySql.Data.MySqlClient;

namespace KinowySystemRezerwacji.service.model
{
    /// <summary>
    /// Klasa reprezentująca encję miejsca_rezerwacje z bazy danych.
    /// </summary>
    class MiejsceRezerwacjaEntity
    {
        /// <summary>
        /// Id miejsca_rezerwacje.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Id rezerwacji.
        /// </summary>
        internal int IdRezerwacji { get; set; }

        /// <summary>
        /// Id miejsca.
        /// </summary>
        internal int IdMiejsca { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal MiejsceRezerwacjaEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            IdRezerwacji = (int)reader["id_rezerwacji"];
            IdMiejsca = (int)reader["id_miejsca"];
        }
    }
}
