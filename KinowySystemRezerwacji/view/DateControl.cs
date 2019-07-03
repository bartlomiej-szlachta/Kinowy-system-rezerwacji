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
    public partial class DateControl : UserControl
    {
        private DateTime[] showingsDates;

        private bool IsAvailableDate(DateTime selectedDate)
        {
            foreach (DateTime date in showingsDates)
            {
                if (selectedDate.Date.Equals(date.Date))
                {
                    return true;
                }
            }
            return false;
        }

        public DateControl()
        {
            InitializeComponent();
            dateTimePicker.MinDate = DateTime.Now;
        }

        internal event Action RequestShowingsDates;
        internal event Action<DateTime> RequestShowingsList;

        internal DateTime[] ShowingsDates
        {
            set
            {
                showingsDates = value;
            }
        }

        private void DateControl_Load(object sender, EventArgs e)
        {
            RequestShowingsDates?.Invoke();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker.Value;
            if (IsAvailableDate(chosenDate))
            {
                RequestShowingsList?.Invoke(chosenDate);
            }
            else
            {
                MessageBox.Show("Tego dnia nie odbywa się żaden seans", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
