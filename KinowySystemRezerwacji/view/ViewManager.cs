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
    internal class ViewManager : IView
    {
        #region Static members

        private static Form activeForm;

        /// <summary>
        /// Przeciążenie jawnego rzutowania na obiekt Form.
        /// </summary>
        /// <param name="view">Obiekt ViewManager</param>
        public static explicit operator Form(ViewManager view)
        {
            return view.GetActiveForm();
        }

        #endregion

        #region Non-static members

        private LoginForm loginForm;
        private MainForm mainForm;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        internal ViewManager()
        {
            InitializeLoginForm();
        }

        /// <summary>
        /// Metoda zwracająca aktywny ekran.
        /// </summary>
        /// <returns>Obiekt Form aktywnego ekranu</returns>
        internal Form GetActiveForm()
        {
            return activeForm;
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

        public void UpdateLoggedInAs(string username)
        {
            if (activeForm == loginForm && username != null)
            {
                InitializeMainForm(username);

                loginForm.Dispose();
                LoginForm.DeleteInstance();
                loginForm = null;
            }
            else if (activeForm == mainForm && username == null)
            {
                InitializeLoginForm();

                mainForm.Dispose();
                mainForm = null;
            }
            else
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd", "Błąd", MessageBoxButtons.OK);
            }
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
            MessageBox.Show(message, success ? "Komunikat" : "Błąd", MessageBoxButtons.OK);
        }
        
        public void Run(Action<IView> RunAction)
        {
            while (activeForm != null)
            {
                RunAction(this);
            }
        }

        #endregion

        #region Private additional methods

        private void InitializeLoginForm()
        {
            loginForm = LoginForm.GetInstance();
            loginForm.RequestRegister += (RegisterRequest request) => RequestRegister?.Invoke(request);
            loginForm.RequestLogIn += (string login, string password) => RequestLogIn?.Invoke(login, password);
            loginForm.FormClosing += (object sender, FormClosingEventArgs e) => activeForm = null;

            activeForm = loginForm;
        }

        private void InitializeMainForm(string username)
        {
            mainForm = new MainForm();
            mainForm.RequestLogOut += () => RequestLogOut?.Invoke();
            mainForm.RequestBookingsList += () => RequestBookingsList?.Invoke();
            mainForm.RequestShowingsList += (DateTime date) => RequestShowingsList?.Invoke(date);
            mainForm.RequestSeatsList += (int showingId) => RequestSeatsList.Invoke(showingId);
            mainForm.RequestBookShowing += (BookSeatsRequest request) => RequestBookShowing?.Invoke(request);
            mainForm.SetLoggedUser(username);
            mainForm.FormClosing += (object sender, FormClosingEventArgs e) => activeForm = null;

            activeForm = mainForm;
        }

        #endregion
    }
}
