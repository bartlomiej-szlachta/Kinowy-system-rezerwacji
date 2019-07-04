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
        private BookingsList bookingsListControl;
        private DateControl chooseDateControl;
        private ShowingsListBox showingsListControl;
        private SeatsView seatsViewControl;

        private void InitializeControl(UserControl control)
        {
            control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            control.Location = new Point(12, 27);
            control.Size = new Size(560, 322);
            Controls.Add(control);
        }

        public MainForm()
        {
            bookingsListControl = new BookingsList();
            chooseDateControl = new DateControl();
            showingsListControl = new ShowingsListBox();
            seatsViewControl = new SeatsView();

            InitializeControl(bookingsListControl);
            InitializeControl(chooseDateControl);
            InitializeControl(showingsListControl);
            InitializeControl(seatsViewControl);
            InitializeComponent();
            
            chooseDateControl.RequestShowingsDates += () => RequestShowingsDates?.Invoke();
            chooseDateControl.RequestShowingsList += (DateTime date) => RequestShowingsList?.Invoke(date);
            showingsListControl.RequestSeatsList += (int id) => RequestSeatsList?.Invoke(id);
            seatsViewControl.RequestBookShowing += (BookSeatsRequest request) => RequestBookShowing?.Invoke(request);
        }

        #region Shared with ViewManager

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
            bookingsListControl.Bookings = response;
        }

        public void ShowShowingsDates(DateTime[] response)
        {
            chooseDateControl.ShowingsDates = response;
        }

        public void ShowShowingsList(ShowingResponse[] response)
        {
            showingsListControl.Showings = response;
            chooseDateControl.Visible = false;
            showingsListControl.Visible = true;
        }

        public void ShowSeatsList(SeatToChooseResponse[] response)
        {
            showingsListControl.Visible = false;
            seatsViewControl.Visible = true;
            seatsViewControl.Seats = response;
            seatsViewControl.ShowingId = showingsListControl.ChosenShowingId;
        }

        #endregion

        #region Generated methods

        private void mojeRezerwacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingsListControl.Visible = true;
            chooseDateControl.Visible = false;
            showingsListControl.Visible = false;
            RequestBookingsList?.Invoke();
        }

        private void repertuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingsListControl.Visible = false;
            chooseDateControl.Visible = true;
            showingsListControl.Visible = false;
            RequestShowingsDates?.Invoke();
        }

        private void wylogujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RequestLogOut?.Invoke();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookingsListControl.Visible = true;
            chooseDateControl.Visible = false;
            showingsListControl.Visible = true;
            RequestBookingsList?.Invoke();
        }

        #endregion
    }
}
