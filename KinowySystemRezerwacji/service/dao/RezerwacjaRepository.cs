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
    /// Repozytorium rezerwacji.
    /// </summary>
    internal class RezerwacjaRepository
    {
        /// <summary>
        /// Metoda wyciągająca z bazy danych dane rezerwacji wykonancych na dany seans.
        /// </summary>
        /// <param name="showingId">ID wybranego seansu</param>
        /// <returns>Dane rezerwacji</returns>
        internal List<RezerwacjaEntity> FindAllBySeansId(int idSeansu)
        {
            List<RezerwacjaEntity> rezerwacje = new List<RezerwacjaEntity>();
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand($"SELECT * FROM rezerwacje WHERE id_seansu = {idSeansu};", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rezerwacje.Add(new RezerwacjaEntity(reader));
                }
                connection.Close();
            }
            return rezerwacje;
        }

        /// <summary>
        /// Metoda wyciągająca z bazy danych dane rezerwacji wykonancych przez danego użytkownika.
        /// </summary>
        /// <param name="idUzytkownika">ID użytkownika</param>
        /// <returns>Dane rezerwacji</returns>
        internal List<RezerwacjaEntity> FindAllByUzytkownikId(int idUzytkownika)
        {
            List<RezerwacjaEntity> rezerwacje = new List<RezerwacjaEntity>();
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand($"SELECT * FROM rezerwacje WHERE id_uzytkownika = {idUzytkownika};", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rezerwacje.Add(new RezerwacjaEntity(reader));
                }
                connection.Close();
            }
            return rezerwacje;
        }
    }
}
