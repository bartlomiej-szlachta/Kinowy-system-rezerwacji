using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinowySystemRezerwacji.view
{
    /// <summary>
    /// Kontrolka zawierająca TextBoxa zawierającego PlaceHoldera oraz ErrorProvidera.
    /// </summary>
    internal partial class ExtendedTextBox : UserControl
    {
        #region Constructor

        /// <summary>
        /// Konstruktor.
        /// </summary>
        public ExtendedTextBox()
        {
            InitializeComponent();
        }

        #endregion

        #region Private fields and getters / setters / other

        private bool shouldBeMasked = false;
        private string placeHolder;
        private bool shouldValidate = false;
        private string errorMessage;
        private Func<string, bool> condition;

        /// <summary>
        /// Metoda ustawiająca maskowanie wprowadzanego tekstu.
        /// </summary>
        /// <param name="value">Informacja o tym, czy maskować hasło</param>
        internal void SetShouldBeMasked(bool value)
        {
            shouldBeMasked = true;
        }

        /// <summary>
        /// Metoda ustawiająca placeholder w TextBoxie.
        /// </summary>
        /// <param name="value">Treść placeholdera</param>
        internal void SetPlaceHolder(string value)
        {
            placeHolder = value;
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = placeHolder;
        }

        /// <summary>
        /// Metoda ustawiająca parametry walidacji pola tekstowego.
        /// </summary>
        /// <param name="errorMessage">Wiadomość do pokazania przy błędzie walidacji</param>
        /// <param name="condition">Warunek, jaki musi spełnić tekst, aby przejść walidację</param>
        internal void SetValidation(string errorMessage, Func<string, bool> condition)
        {
            shouldValidate = true;
            this.errorMessage = errorMessage;
            this.condition = condition;
        }

        /// <summary>
        /// Metoda włączająca / wyłączająca walidację dla TextBoxa.
        /// </summary>
        /// <param name="value">Wartość logiczna informująca, czy pole ma być walidowane</param>
        internal void SetShouldValidate(bool value)
        {
            shouldValidate = value;
        }

        /// <summary>
        /// Metoda zwracająca tekst wpisany do TextBoxa.
        /// </summary>
        /// <returns>Tekst wpisany do TextBoxa</returns>
        internal string GetText()
        {
            return textBox1.Text;
        }

        /// <summary>
        /// Metoda resetująca TextBoxa.
        /// </summary>
        internal void SetEmpty()
        {
            errorProvider1.Clear();
            textBox1.PasswordChar = '\0';
            textBox1.Text = placeHolder;
            textBox1.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Metoda walidująca pole tekstowe.
        /// </summary>
        /// <returns>Rezultat walidacji</returns>
        internal bool ValidateAndGetResult()
        {
            if (condition == null)
            {
                return true;
            }
            else if (condition(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "");
                return true;
            }
            else
            {
                errorProvider1.SetError(textBox1, errorMessage);
                return false;
            }
        }

        #endregion

        #region Windows Forms event handlers

        private void ExtendedTextBox_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeHolder)
            {
                if (shouldBeMasked)
                {
                    textBox1.PasswordChar = '*';
                }
                textBox1.Text = "";
                textBox1.ForeColor = Color.Empty;
            }
        }

        private void ExtendedTextBox_Leave(object sender, EventArgs e)
        {
            if (shouldValidate)
            {
                ValidateAndGetResult();
            }
            if (textBox1.Text == "")
            {
                textBox1.PasswordChar = '\0';
                textBox1.Text = placeHolder;
                textBox1.ForeColor = Color.Gray;
            }
        }

        #endregion
    }
}
