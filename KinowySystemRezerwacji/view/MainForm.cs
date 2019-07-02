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
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //extendedMonthCalendar.RequestShowingsList += (DateTime date) => RequestShowingsList?.Invoke(date);
            //extendedMonthCalendar.RequestShowingsDates += () => RequestShowingsDates?.Invoke();
        }

        internal void SetLoggedUser(string username)
        {
            użytkownikToolStripMenuItem.Text = "Zalogowany jako: " + username;
        }

        public event Action RequestLogOut;
        public event Action RequestBookingsList;
        public event Action<DateTime> RequestShowingsList;
        public event Action<int> RequestSeatsList;
        public event Action<BookSeatsRequest> RequestBookShowing;
        public event Action RequestShowingsDates;
        
        public void ShowBookingsList(BookingResponse[] response)
        {
            throw new NotImplementedException();
        }

        public void ShowShowingsDates(DateTime[] response)
        {
            //extendedMonthCalendar.ShowingsDates = response;
        }

        public void ShowShowingsList(ShowingResponse[] response)
        {
            throw new NotImplementedException();
        }

        public void ShowSeatsList(SeatToChooseResponse[] response)
        {
            throw new NotImplementedException();
        }

        private void wylogujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RequestLogOut?.Invoke();
        }
    }
}
