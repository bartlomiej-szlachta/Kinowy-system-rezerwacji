using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinowySystemRezerwacji.dto;

namespace KinowySystemRezerwacji.view
{
    /// <summary>
    /// Główna klasa widoku, zarządzająca ekranami.
    /// </summary>
    internal class ViewPresenter : IView
    {
        #region Static members

        private static Form activeForm;
        public static implicit operator Form(ViewPresenter view) { return activeForm; }

        #endregion

        #region

        private LoginForm loginForm;
        private MainForm mainForm;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        internal ViewPresenter()
        {
            loginForm = LoginForm.GetInstance();
            activeForm = loginForm;
            loginForm.RequestRegister += (RegisterRequest request) => RequestRegister?.Invoke(request);
            loginForm.RequestLogIn += (string login, string password) => RequestLogIn?.Invoke(login, password);
        }

        #endregion

        #region IView members

        public event Action<RegisterRequest> RequestRegister;
        public event Action<string, string> RequestLogIn;
        public event Action RequestLogOut;
        public event Action RequestBookingsList;
        public event Action<DateTime> RequestShowingsList;
        public event Action<int> RequestSeatsList;
        public event Action<BookSeatsRequest> RequestBookShowing;

        public void LoggingInCompleted(string username)
        {
            loginForm = null;
            mainForm = new MainForm();
            activeForm = mainForm;
            mainForm.RequestLogOut += () => RequestLogOut?.Invoke();
            mainForm.RequestBookingsList += () => RequestBookingsList?.Invoke();
            mainForm.RequestShowingsList += (DateTime date) => RequestShowingsList?.Invoke(date);
            mainForm.RequestSeatsList += (int showingId) => RequestSeatsList.Invoke(showingId);
            mainForm.RequestBookShowing += (BookSeatsRequest request) => RequestBookShowing?.Invoke(request);
        }

        public void ShowBookingsList(BookingResponse[] response)
        {
            mainForm.ShowBookingsList(response);
        }

        public void ShowShowingsList(ShowingResponse[] response)
        {
            mainForm.ShowShowingsList(response);
        }

        public void ShowSeatsList(SeatToChooseResponse[] response)
        {
            mainForm.ShowSeatsList(response);
        }

        public void ShowMessage(bool success, string message)
        {
            MessageBox.Show(message, success ? "Message" : "Error", MessageBoxButtons.OK);
        }

        #endregion
    }
}
