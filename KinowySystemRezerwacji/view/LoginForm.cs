using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using KinowySystemRezerwacji.dto;

namespace KinowySystemRezerwacji.view
{
    /// <summary>
    /// Formularz logowania do systemu, zaprojektowany jako singleton.
    /// </summary>
    internal partial class LoginForm : Form
    {
        #region Singleton elements

        /// <summary>
        /// Instancja klasy.
        /// </summary>
        private static LoginForm instance = null;

        /// <summary>
        /// Metoda tworząca instancję klasy, jeśli ta jeszcze nie istnieje.
        /// </summary>
        /// <returns>Nowo utworzona lub wcześniej istniejąca instancja klasy</returns>
        internal static LoginForm GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginForm();
            }
            return instance;
        }

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

            usernameExtendedTextBox.SetValidation("Nazwa użytkownika musi zawierać co najmniej 8 znaków", 
                (string text) => text.Length >= 8 && !text.Contains(" "));
            passwordExtendedTextBox.SetValidation("Hasło musi zawierać co najmniej 8 znaków, co najmniej jedną cyfrę i co najmniej jedną wielką literę", 
                (string text) => !new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$").Match(text).Success);
            firstNameExtendedTextBox.SetValidation("Imię musi rozpoczynać się z wielkiej litery", 
                (string text) => text.Length > 0 && text.First() == text.ToUpper().First());
            lastNameExtendedTextBox.SetValidation("Nazwisko musi rozpoczynać się z wielkiej litery", 
                (string text) => text.Length > 0 && text.First() == text.ToUpper().First());
            emailExtendedTextBox.SetValidation("Podany e-mail jest nieprawidłowy", 
                (string text) => new EmailAddressAttribute().IsValid(text));

            confirmLoginRegisterButton.Top = 152;
        }

        #endregion

        public event Action<RegisterRequest> RequestRegister;
        public event Action<string, string> RequestLogIn;

        private enum Mode { LOGIN, REGISTER };

        private Mode mode = Mode.LOGIN;

        private void ResetTextFields()
        {
            usernameExtendedTextBox.SetEmpty();
            passwordExtendedTextBox.SetEmpty();
            firstNameExtendedTextBox.SetEmpty();
            lastNameExtendedTextBox.SetEmpty();
            emailExtendedTextBox.SetEmpty();
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
