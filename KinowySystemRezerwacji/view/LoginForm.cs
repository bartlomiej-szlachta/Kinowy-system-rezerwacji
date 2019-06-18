using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinowySystemRezerwacji.dto;

namespace KinowySystemRezerwacji.view
{
    /// <summary>
    /// Formularz logowania do systemu, zaprojektowany jako singleton.
    /// </summary>
    partial class LoginForm : Form
    {
        #region Singleton elements

        private static LoginForm instance = null;
        private LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda tworząca obiekt ekranu logowania, jeśli ten jeszcze nie istnieje.
        /// </summary>
        /// <returns>Obiekt ekranu logowania</returns>
        internal static LoginForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }

        #endregion

        public event Action<RegisterRequest> RequestRegister;
        public event Action<string, string> RequestLogIn;


    }
}
