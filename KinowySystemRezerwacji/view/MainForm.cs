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
        private DateControl dateControl;
        //private ShowingsList showingsList;
        private ShowingsListBox listBoxShowing;

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
            dateControl = new DateControl();
            //showingsList = new ShowingsList();
            listBoxShowing = new ShowingsListBox();

            InitializeControl(bookingsListControl);
            InitializeControl(dateControl);
            //InitializeControl(showingsList);
            InitializeControl(listBoxShowing);
            InitializeComponent();
            
            dateControl.RequestShowingsDates += () => RequestShowingsDates?.Invoke();
            dateControl.RequestShowingsList += (DateTime date) => 
            RequestShowingsList?.Invoke(date);
            //showingsList.RequestSeatsList += (int id) => RequestSeatsList?.Invoke(id);
            listBoxShowing.RequestSeatsList += (int id) => RequestSeatsList?.Invoke(id);
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
            dateControl.ShowingsDates = response;
        }

        public void ShowShowingsList(ShowingResponse[] response)
        {
            //showingsList.Showings = response;
            listBoxShowing.Showings = response;
            dateControl.Visible = false;
            //showingsList.Visible = true;
            listBoxShowing.Visible = true;
        }

        public void ShowSeatsList(SeatToChooseResponse[] response)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Generated methods

        private void mojeRezerwacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingsListControl.Visible = true;
            dateControl.Visible = false;
            //showingsList.Visible = false;
            listBoxShowing.Visible = false;
            RequestBookingsList?.Invoke();
        }

        private void repertuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookingsListControl.Visible = false;
            dateControl.Visible = true;
            //showingsList.Visible = false;
            listBoxShowing.Visible = false;
            RequestShowingsDates?.Invoke();
        }

        private void wylogujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RequestLogOut?.Invoke();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bookingsListControl.Visible = true;
            dateControl.Visible = false;
            //showingsList.Visible = true;
            listBoxShowing.Visible = true;
            RequestBookingsList?.Invoke();
        }

        #endregion
    }
}
