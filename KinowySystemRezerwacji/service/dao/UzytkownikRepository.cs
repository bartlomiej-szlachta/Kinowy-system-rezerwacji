using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KinowySystemRezerwacji.service.model;

namespace KinowySystemRezerwacji.service.dao
{
    /// <summary>
    /// Repozytorium użytkowników.
    /// </summary>
    internal class UzytkownikRepository
    {
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
