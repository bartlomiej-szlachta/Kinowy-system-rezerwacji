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
        #region Static members

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

        #endregion

        #region Events

        public event Action<RegisterRequest> RequestRegister;
        public event Action<string, string> RequestLogIn;

        #endregion

        #region Mode

        /// <summary>
        /// Enum określający wybrany tryb - logowania lub rejestracji.
        /// </summary>
        private enum Mode { LOGIN, REGISTER };

        private Mode mode = Mode.LOGIN;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Konstruktor, lol.
        /// </summary>
        private LoginForm()
        {
            InitializeComponent();
            passwordExtendedTextBox.SetShouldBeMasked(true);

            usernameExtendedTextBox.SetPlaceHolder("Nazwa użytkownika");
            passwordExtendedTextBox.SetPlaceHolder("Hasło");
            firstNameExtendedTextBox.SetPlaceHolder("Imię");
            lastNameExtendedTextBox.SetPlaceHolder("Nazwisko");
            emailExtendedTextBox.SetPlaceHolder("E-mail");

            usernameExtendedTextBox.SetValidation("Nazwa użytkownika musi zawierać od 8 do 14 znaków oraz nie może zawierać znaku spacji", 
                (string text) => text.Length >= 8 && text.Length <= 14 && !text.Contains(" "));
            passwordExtendedTextBox.SetValidation("Hasło musi zawierać co najmniej 8 znaków, co najmniej jedną cyfrę i co najmniej jedną wielką literę", 
                (string text) => !new Regex(@"^(.{0,7}|[^0-9]*|[^A-Z])$").Match(text).Success);
            firstNameExtendedTextBox.SetValidation("Imię musi rozpoczynać się z wielkiej litery oraz zawierać co najwyżej 20 znaków", 
                (string text) => text.Length > 0 && text.Length <= 20 && text.Length <= 20 && text.First() == text.ToUpper().First());
            lastNameExtendedTextBox.SetValidation("Nazwisko musi rozpoczynać się z wielkiej litery oraz zawierać co najwyżej 30 znaków", 
                (string text) => text.Length > 0 && text.Length <= 30 && text.First() == text.ToUpper().First());
            emailExtendedTextBox.SetValidation("Podany e-mail jest nieprawidłowy", 
                (string text) => text.Length <= 30 && new EmailAddressAttribute().IsValid(text));

            confirmLoginRegisterButton.Top = 152;

            usernameExtendedTextBox.SetShouldValidate(false);
            passwordExtendedTextBox.SetShouldValidate(false);
        }

        #endregion

        #region Windows Forms event handlers

        private void confirmLoginRegisterButton_Click(object sender, EventArgs e)
        {
            if (mode == Mode.LOGIN)
            {
                RequestLogIn?.Invoke(usernameExtendedTextBox.GetText(), passwordExtendedTextBox.GetText());
            }
            else if (mode == Mode.REGISTER && usernameExtendedTextBox.ValidateAndGetResult() && passwordExtendedTextBox.ValidateAndGetResult()  && firstNameExtendedTextBox.ValidateAndGetResult() && lastNameExtendedTextBox.ValidateAndGetResult() && emailExtendedTextBox.ValidateAndGetResult())
            {
                RegisterRequest request = new RegisterRequest
                {
                    Username = usernameExtendedTextBox.GetText(),
                    Password = passwordExtendedTextBox.GetText(),
                    FirstName = firstNameExtendedTextBox.GetText(),
                    LastName = lastNameExtendedTextBox.GetText(),
                    Email = emailExtendedTextBox.GetText()
                };
                RequestRegister?.Invoke(request);
            }
            else
            {
                MessageBox.Show("Wpisano niepoprawne dane", "Błąd", MessageBoxButtons.OK);
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
                usernameExtendedTextBox.SetShouldValidate(true);
                passwordExtendedTextBox.SetShouldValidate(true);

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
                usernameExtendedTextBox.SetShouldValidate(false);
                passwordExtendedTextBox.SetShouldValidate(false);
            }

            usernameExtendedTextBox.SetEmpty();
            passwordExtendedTextBox.SetEmpty();
            firstNameExtendedTextBox.SetEmpty();
            lastNameExtendedTextBox.SetEmpty();
            emailExtendedTextBox.SetEmpty();
        }

        #endregion
    }
}
