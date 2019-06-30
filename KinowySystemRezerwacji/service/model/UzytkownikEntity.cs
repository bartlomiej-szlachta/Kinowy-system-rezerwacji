using MySql.Data.MySqlClient;
using System;

namespace KinowySystemRezerwacji.service.model
{
    /// <summary>
    /// Klasa reprezentująca encję użytkownika z bazy danych.
    /// </summary>
    internal class UzytkownikEntity
    {
        /// <summary>
        /// Id użytkownika.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Nazwa użytkownika.
        /// </summary>
        internal string NazwaUzytkownika { get; set; }

        /// <summary>
        /// Zahaszowane hasło użytkownika.
        /// </summary>
        internal string Haslo { get; set; }

        /// <summary>
        /// Imię użytkownika.
        /// </summary>
        internal string Imie { get; set; }

        /// <summary>
        /// Nazwisko użytkownika.
        /// </summary>
        internal string Nazwisko { get; set; }

        /// <summary>
        /// Email użytkownika.
        /// </summary>
        internal string Email { get; set; }

        /// <summary>
        /// Data urodzenia użytkownika.
        /// </summary>
        internal DateTime? DataUrodzenia { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal UzytkownikEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            NazwaUzytkownika = (string)reader["nazwa_uzytkownika"];
            Haslo = (string)reader["ukryte_haslo"];
            Imie = (string)reader["imie"];
            Nazwisko = (string)reader["nazwisko"];
            Email = (string)reader["email"];

            var temp = reader["data_urodzenia"];
            if (temp is DBNull)
            {
                DataUrodzenia = null;
            }
            else
            {
                DataUrodzenia = (DateTime)temp;
            }
        }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="username">Nazwa użytkownika</param>
        /// <param name="password">Zahaszowane hasło użytkownika</param>
        /// <param name="firstName">Imię użytkownika</param>
        /// <param name="lastName">Nazwisko użytkownika</param>
        /// <param name="email">Email użytkownika</param>
        /// <param name="birthday">Data urodzenia użytkownika</param>
        internal UzytkownikEntity(string username, string password, string firstName, string lastName, string email, DateTime birthday)
        {
            NazwaUzytkownika = username;
            Haslo = password;
            Imie = firstName;
            Nazwisko = lastName;
            Email = email;
            DataUrodzenia = birthday;
        }
    }
}