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
        internal string Nazwa_uzytkownika { get; set; }

        /// <summary>
        /// Ukryte hasło użytkownika.
        /// </summary>
        internal string Ukryte_haslo { get; set; }

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
        internal DateTime Data_urodzenia { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal UzytkownikEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            Nazwa_uzytkownika = (string)reader["nazwa_uzytkownika"];
            Ukryte_haslo = (string)reader["ukryte_haslo"];
            Imie = (string)reader["imie"];
            Nazwisko = (string)reader["nazwisko"];
            Email = (string)reader["email"];
            Data_urodzenia = (DateTime)reader["data_urodzenia"];
        }

        internal UzytkownikEntity(string username,string password, string firstName, string lastName, string email, DateTime birthday)
        {
            Nazwa_uzytkownika = username;
            Ukryte_haslo = password;
            Imie = firstName;
            Nazwisko = lastName;
            Email = email;
            Data_urodzenia = birthday;
        }
    }
}
