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
    internal partial class LoginForm : Form
    {
        #region Singleton elements

        private static LoginForm instance = null;

        /// <summary>
        /// Konstruktor, lol.
        /// </summary>
        private LoginForm()
        {
            InitializeComponent();
            passwordExtendedTextBox.SetTextMask(true);
            usernameExtendedTextBox.PlaceHolder = "Nazwa użytkownika";
            passwordExtendedTextBox.PlaceHolder = "Hasło";
            firstNameExtendedTextBox.PlaceHolder = "Imię";
            lastNameExtendedTextBox.PlaceHolder = "Nazwisko";
            emailExtendedTextBox.PlaceHolder = "E-mail";
            confirmLoginRegisterButton.Top = 152;
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

        private enum Mode { LOGIN, REGISTER };

        private Mode mode = Mode.LOGIN;

        private void ResetTextFields()
        {
            //usernameExtendedTextBox.Text = "";
            //passwordExtendedTextBox.Text = "";
            //firstNameExtendedTextBox.Text = "";
            //lastNameExtendedTextBox.Text = "";
            //emailExtendedTextBox.Text = "";
        }

        private void confirmLoginRegisterButton_Click(object sender, EventArgs e)
        {
            if (mode == Mode.LOGIN)
            {
                RequestLogIn?.Invoke(usernameExtendedTextBox.Text, passwordExtendedTextBox.Text);
            }
            if (mode == Mode.REGISTER)
            {
                RegisterRequest request = new RegisterRequest
                {
                    Username = usernameExtendedTextBox.Text,
                    Password = passwordExtendedTextBox.Text,
                    FirstName = firstNameExtendedTextBox.Text,
                    LastName = lastNameExtendedTextBox.Text,
                    Email = emailExtendedTextBox.Text
                };
                RequestRegister?.Invoke(request);
            }
        }

        private void switchLoginRegisterButton_Click(object sender, EventArgs e)
        {
            if (mode == Mode.LOGIN)
            {
                mode = Mode.REGISTER;
                titleLabel.Text = "Rejestracja";
                confirmLoginRegisterButton.Text = "Zarejestruj";
                switchLoginRegisterButton.Text = "Tryb logowania";
                firstNameExtendedTextBox.Visible = true;
                lastNameExtendedTextBox.Visible = true;
                emailExtendedTextBox.Visible = true;
                confirmLoginRegisterButton.Top = 276;
                ResetTextFields();
            }
            else if (mode == Mode.REGISTER)
            {
                mode = Mode.LOGIN;
                titleLabel.Text = "Logowanie";
                confirmLoginRegisterButton.Text = "Zaloguj";
                switchLoginRegisterButton.Text = "Tryb rejestracji";
                firstNameExtendedTextBox.Visible = false;
                lastNameExtendedTextBox.Visible = false;
                emailExtendedTextBox.Visible = false;
                confirmLoginRegisterButton.Top = 152;
                ResetTextFields();
            }
        }
    }
}
