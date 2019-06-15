using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinowySystemRezerwacji.dto;
using KinowySystemRezerwacji.model;

namespace KinowySystemRezerwacji
{
    /// <summary>
    /// Prezenter modelu MVP.
    /// </summary>
    class Presenter
    {
        /// <summary>
        /// Model zawierający logikę biznesową.
        /// </summary>
        private Model model;

        /// <summary>
        /// Widok zawierający interfejs użytkownika.
        /// </summary>
        private IView view;

        /// <summary>
        /// Konstruktor.
        /// </summary>
        /// <param name="model">Model zawierający logikę biznesową</param>
        /// <param name="view">Widok zawierający interfejs użytkownika</param>
        internal Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            view.RequestRegister += HandleRegister;
            view.RequestLogIn += HandleLogIn;
            view.RequestLogOut += HandleLogOut;
            view.RequestBookingsList += HandleBookingsList;
            view.RequestShowingsList += HandleShowingsList;
            view.RequestSeatsList += HandleSeatsList;
            view.RequestBookShowing += HandleBookShowing;
            model.BasicResponse += HandleBasicResponse;
        }
        
        /// <summary>
        /// Metoda obsługująca event rejestracji nowego użytkownika.
        /// </summary>
        /// <param name="request"></param>
        private void HandleRegister(RegisterRequest request)
        {
            try
            {
                model.Register(request);
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event logowania.
        /// </summary>
        /// <param name="username">Nazwa użytkownika</param>
        /// <param name="password">Zahashowane hasło</param>
        private void HandleLogIn(string username, string password)
        {
            try
            {
                model.LogIn(username, password);
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event wylogowywania z systemu.
        /// </summary>
        private void HandleLogOut()
        {
            try
            {
                model.LogOut();
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event uzyskania listy rezerwacji.
        /// </summary>
        private void HandleBookingsList()
        {
            try
            {
                view.ShowBookingsList(model.GetBookings());
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event uzyskania listy dostępnych seansów.
        /// </summary>
        private void HandleShowingsList()
        {
            try
            {
                view.ShowShowingsList(model.GetShowings());
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event uzyskania listy miejsc na dany seans.
        /// </summary>
        /// <param name="showingId">ID seansu</param>
        private void HandleSeatsList(int showingId)
        {
            try
            {
                view.ShowSeatsList(model.GetSeats(showingId));
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event rezerwowania miejsc na dany seans.
        /// </summary>
        /// <param name="request">Dane dotyczące seansu i wybranych miejsc</param>
        private void HandleBookShowing(BookSeatsRequest request)
        {
            try
            {
                model.BookSeats(request);
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, ex.Message);
            }
        }

        /// <summary>
        /// Metoda obsługująca event prostej odpowiedzi modelu.
        /// </summary>
        /// <param name="success">Informacja o pozytywnym statusie odpowiedzi</param>
        /// <param name="message">Komunikat</param>
        private void HandleBasicResponse(bool success, string message)
        {
            view.ShowMessage(success, message);
        }
    }
}
