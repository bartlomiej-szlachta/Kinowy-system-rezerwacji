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
    /// Repozytorium seansów.
    /// </summary>
    internal class SeansRepository
    {
        /// <summary>
        /// Metoda wyciągająca z bazy danych dane dotyczące wszystkich seansów w danym dniu.
        /// </summary>
        /// <returns>Lista seansów</returns>
        internal List<SeansEntity> FindByKiedy(DateTime kiedy)
        {
            List<SeansEntity> projections = new List<SeansEntity>();
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM seanse WHERE DATE(kiedy) = '" + kiedy.ToString("yyyy-MM-dd") + "';", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    projections.Add(new SeansEntity(reader));
                }
                connection.Close();
            }
            return projections;
        }
    }
}
