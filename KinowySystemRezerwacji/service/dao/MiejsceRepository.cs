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
    /// Repozytorium miejsc.
    /// </summary>
    internal class MiejsceRepository
    {
        /// <summary>
        /// Metoda wyciągająca z bazy danych dane dotyczące wszystkich miejsc na sali.
        /// </summary>
        /// <returns>Lista miejsc</returns>
        internal static List<MiejsceEntity> FindAll()
        {
            List<MiejsceEntity> miejsca = new List<MiejsceEntity>();
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM miejsca;", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miejsca.Add(new MiejsceEntity(reader));
                }
                connection.Close();
            }
            return miejsca;
        }
    }
}
