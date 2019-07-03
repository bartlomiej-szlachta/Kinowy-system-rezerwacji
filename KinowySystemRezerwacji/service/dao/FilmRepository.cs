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
        /// Metoda uzyskująca z bazy danych film o wybranym ID.
        /// </summary>
        /// <param name="id">Id szukanego filmu</param>
        /// <returns>Encja filmu oraz informacja o sukcesie operacji</returns>
        internal Optional<FilmEntity> FindById(int id)
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
            return new Optional<FilmEntity>(movie);
        }
    }
}
