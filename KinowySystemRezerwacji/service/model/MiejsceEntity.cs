using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KinowySystemRezerwacji.service.model
{
    /// <summary>
    /// Klasa reprezentująca encję miejsca z bazy danych.
    /// </summary>
    internal class MiejsceEntity
    {
        /// <summary>
        /// Id miejsca.
        /// </summary>
        internal int Id { get; set; }

        /// <summary>
        /// Rząd miejsca (współrzędna pionowa).
        /// </summary>
        internal int Rzad { get; set; }

        /// <summary>
        /// Numer miejsca (współrzędna pozioma).
        /// </summary>
        internal int Numer { get; set; }

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="reader">Obiekt readera MySql</param>
        internal MiejsceEntity(MySqlDataReader reader)
        {
            Id = (int)reader["id"];
            Rzad = (int)reader["rzad"];
            Numer = (int)reader["numer"];
        }
    }
}
