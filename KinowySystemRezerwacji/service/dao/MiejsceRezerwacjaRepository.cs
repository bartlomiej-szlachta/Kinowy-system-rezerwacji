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
    /// Repozytorium miejsc-rezerwacji.
    /// </summary>
    internal class MiejsceRezerwacjaRepository
    {
        /// <summary>
        /// Metoda wyciągająca z bazy danych dane miejsc-rezerwacji dotyczących danej rezerwacji.
        /// </summary>
        /// <param name="idRezerwacji">ID rezerwacji</param>
        /// <returns>Dane miejsc-rezerwacji</returns>
        internal List<MiejsceRezerwacjaEntity> FindAllByRezerwacjaId(int idRezerwacji)
        {
            List<MiejsceRezerwacjaEntity> miejscaRezerwacje = new List<MiejsceRezerwacjaEntity>();
            MySqlConnection connection = DBConnection.Instance.Connection;
            using (MySqlCommand command = new MySqlCommand($"SELECT * FROM miejsca_rezerwacje WHERE id_rezerwacji = {idRezerwacji};", connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    miejscaRezerwacje.Add(new MiejsceRezerwacjaEntity(reader));
                }
                connection.Close();
            }
            return miejscaRezerwacje;
        }
    }
}
