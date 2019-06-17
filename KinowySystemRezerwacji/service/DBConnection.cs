using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KinowySystemRezerwacji.service
{
    /// <summary>
    /// Klasa reprezentująca połączenie z bazą danych.
    /// </summary>
    internal class DBConnection
    {
        /// <summary>
        /// Instancja klasy.
        /// </summary>
        private static DBConnection instance = null;

        /// <summary>
        /// Properties zwracający instancję klasy.
        /// </summary>
        internal static DBConnection Instance
        {
            get
            {
                return instance ?? (instance = new DBConnection());
            }
        }

        /// <summary>
        /// Obiekt łączący z silnikiem bazy danych.
        /// </summary>
        internal MySqlConnection Connection { get; private set; }

        /// <summary>
        /// Prywatny konstruktor.
        /// </summary>
        private DBConnection()
        {
            MySqlConnectionStringBuilder connStrBuilder = new MySqlConnectionStringBuilder
            {
                Server = DBInfo.Server,
                UserID = DBInfo.User,
                Password = DBInfo.Password,
                Database = DBInfo.DataBase,
                Port = uint.Parse(DBInfo.Port)
            };
            Console.WriteLine(connStrBuilder);

            Connection = new MySqlConnection(connStrBuilder.ToString());
        }
    }
}
