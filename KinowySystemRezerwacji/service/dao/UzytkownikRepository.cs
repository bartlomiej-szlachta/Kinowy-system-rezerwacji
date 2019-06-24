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
        internal UzytkownikEntity FindByNazwaUzytkownika(string username)
        {
            UzytkownikEntity user;
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE users.id = " + username + ";", connection))
            {
                connection.Open();
                user = new UzytkownikEntity(command.ExecuteReader());
                connection.Close();
            }
            if (user == null)
            {
                throw new Exception("Użytkownik o podanej nazwie nie istnieje");
            }
            return user;
        }
    }
}
