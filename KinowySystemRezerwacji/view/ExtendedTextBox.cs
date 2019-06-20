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
        /// <summary>
        /// Konstruktor.
        /// </summary>
        public ExtendedTextBox()
        {
            InitializeComponent();
        }

        private string placeHolder;

        /// <summary>
        /// Tekst wyświetlany w TextBoxie, gdy nie jest do niego wprowadzany tekst.
        /// </summary>
        internal string PlaceHolder
        {
            get
            {
                return placeHolder;
            }
            set
            {
                placeHolder = value;
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = placeHolder;
            }
        }

        /// <summary>
        /// Tekst wpisany do TextBoxa.
        /// </summary>
        public override string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        /// <summary>
        /// Metoda uruchamiająca ErrorProvidera obok TextBoxa.
        /// </summary>
        /// <param name="message">Treść komunikatu</param>
        internal void SetError(string message)
        {
            errorProvider1.SetError(textBox1, message);
        }

        /// <summary>
        /// Metoda ustawiająca maskowanie wprowadzanego tekstu.
        /// </summary>
        /// <param name="value">Informacja o tym, czy maskować hasło</param>
        internal void SetTextMask(bool value)
        {
            shouldBeMasked = true;
        }

        private bool shouldBeMasked = false;

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
            if (textBox1.Text == "")
            {
                textBox1.PasswordChar = '\0';
                textBox1.Text = placeHolder;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void ExtendedTextBox_Load(object sender, EventArgs e)
        {
            textBox1.Text = placeHolder;
        }
    }
}
