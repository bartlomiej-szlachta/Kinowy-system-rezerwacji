using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinowySystemRezerwacji.dto;
using KinowySystemRezerwacji.service;

namespace KinowySystemRezerwacji
{
    /// <summary>
    /// Prezenter modelu MVP.
    /// </summary>
    class Presenter
    {

        #region Private fields

        /// <summary>
        /// Model zawierający logikę biznesową.
        /// </summary>
        private Service model;

        /// <summary>
        /// Widok zawierający interfejs użytkownika.
        /// </summary>
        private IView view;

        #endregion

        #region Constructor

        /// <summary>
        /// Konstruktor, lol.
        /// </summary>
        /// <param name="model">Model zawierający logikę biznesową</param>
        /// <param name="view">Widok zawierający interfejs użytkownika</param>
        internal Presenter(Service model, IView view)
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
            model.LoggingInCompleted += HandleLoggingInCompleted;
            model.BasicResponse += HandleBasicResponse;
        }

        #endregion

        #region Event handlers

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
                view.ShowMessage(false, TranslateToPolish(ex.Message));
            }
        }

        /// <summary>
        /// Metoda obsługująca event logowania.
        /// </summary>
        /// <param name="username">Nazwa użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        private void HandleLogIn(string username, string password)
        {
            try
            {
                model.LogIn(username, password);
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, TranslateToPolish(ex.Message));
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
                view.ShowMessage(false, TranslateToPolish(ex.Message));
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
                view.ShowMessage(false, TranslateToPolish(ex.Message));
            }
        }

        /// <summary>
        /// Metoda obsługująca event uzyskania listy dostępnych seansów.
        /// </summary>
        /// <param name="date">Data, dla której mają zostać wyświetlone seanse</param>
        private void HandleShowingsList(DateTime date)
        {
            try
            {
                view.ShowShowingsList(model.GetShowings(date));
            }
            catch (Exception ex)
            {
                view.ShowMessage(false, TranslateToPolish(ex.Message));
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
                view.ShowMessage(false, TranslateToPolish(ex.Message));
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
                view.ShowMessage(false, TranslateToPolish(ex.Message));
            }
        }

        /// <summary>
        /// Metoda obsługująca event ukończenia logowania się do systemu.
        /// </summary>
        /// <param name="username">Nazwa zalogowanego użytkownika</param>
        private void HandleLoggingInCompleted(string username)
        {
            view.LoggingInCompleted(username);
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

        #endregion

        #region Additional methods

        private string TranslateToPolish(string message)
        {
            switch (message)
            {
                case "Unable to connect to any of the specified MySQL hosts.":
                    {
                        return "Nie udało się uzyskać połączenia z bazą danych.";
                    }
                default:
                    {
                        return message;
                    }
            }
        }

        #endregion
    }
}
