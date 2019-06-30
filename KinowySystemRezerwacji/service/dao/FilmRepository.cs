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
    /// Repozytorium filmów.
    /// </summary>
    internal class FilmRepository
    {
        /// <summary>
        /// Metoda wyszukuje w bazie danych film o wybranym id.
        /// </summary>
        /// <param name="id">Id filmu, którego szukamy</param>
        /// <returns>Zwraca encję filmu wyszukanego w bazie</returns>
        internal FilmEntity FindById(int id)
        {
            FilmEntity movie = null;
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM filmy f WHERE f.id = '" + id + "';", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    movie = new FilmEntity(reader);
                }
                connection.Close();
            }
            return movie;
        }
    }
}
