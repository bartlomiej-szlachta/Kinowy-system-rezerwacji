using KinowySystemRezerwacji.service.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinowySystemRezerwacji.service.dao
{
    /// <summary>
    /// Repozytorium użytkowników.
    /// </summary>
    internal class UzytkownikRepository
    {
        /// <summary>
        /// Metoda zapisująca użytkownika do bazy danych.
        /// <param name="uzytkownik">Encja użytkownika, którego zapiszemy do bazy</param>
        /// </summary>
        internal void Save(UzytkownikEntity uzytkownik)
        {
            MySqlConnection connection = DBConnection.Instance.Connection;
            connection.Open();
            MySqlCommand insertingCommand = connection.CreateCommand();
            insertingCommand.CommandText = "INSERT INTO Uzytkownicy(nazwa_uzytkownika, ukryte_haslo, imie, nazwisko, email, data_urodzenia) VALUES (?nazwa_uzytkownika, ?ukryte_haslo, ?imie, ?nazwisko, ?email, ?data_urodzenia)";
            insertingCommand.Parameters.AddWithValue("?nazwa_uzytkownika", uzytkownik.NazwaUzytkownika);
            insertingCommand.Parameters.AddWithValue("?ukryte_haslo", Security.HashPassword(uzytkownik.Haslo));
            insertingCommand.Parameters.AddWithValue("?imie", uzytkownik.Imie);
            insertingCommand.Parameters.AddWithValue("?nazwisko", uzytkownik.Nazwisko);
            insertingCommand.Parameters.AddWithValue("?email", uzytkownik.Email);
            insertingCommand.Parameters.AddWithValue("?data_urodzenia", uzytkownik.DataUrodzenia.Value.ToString("yyyy-MM-dd"));
            insertingCommand.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// Metoda sprawdzająca w bazie danych czy użytkownik o takiej nazwie istnieje.
        /// </summary>
        /// <param name="username">Nazwa użytkownika, którą sprawdzamy</param>
        /// <returns>Prawda/Fałsz</returns>
        internal bool ExistsByNazwaUzytkownika(string username)
        {
            Optional<UzytkownikEntity> user = FindByNazwaUzytkownika(username);
            return user.Success;
        }

        /// <summary>
        /// Metoda wyszukuje w bazie danych użytkownika o wybranej nazwie.
        /// </summary>
        /// <param name="username">Nazwa użytkownika, którego szukamy</param>
        /// <returns>Zwraca encję użytkownika jeżeli istnieje</returns>
        internal Optional<UzytkownikEntity> FindByNazwaUzytkownika(string username)
        {
            UzytkownikEntity user = null;
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM uzytkownicy u WHERE u.nazwa_uzytkownika = '" + username + "';", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user = new UzytkownikEntity(reader);
                }
                connection.Close();
            }
            return new Optional<UzytkownikEntity>(user);
        }
       
    }
}

