using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using KinowySystemRezerwacji.model;
using KinowySystemRezerwacji.service;

namespace KinowySystemRezerwacji.dao
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
        internal static List<Miejsce> FindAll()
        {
            List<Miejsce> miejsca = new List<Miejsce>();
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM miejsca;", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miejsca.Add(new Miejsce(reader));
                }
                connection.Close();
            }
            return miejsca;
        }
    }
}
