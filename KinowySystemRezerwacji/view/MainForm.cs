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
    /// <summary>
    /// Główny formularz widoku.
    /// </summary>
    partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event Action<RegisterRequest> RequestRegister;
        public event Action<string, string> RequestLogIn;
        public event Action RequestLogOut;
        public event Action RequestBookingsList;
        public event Action RequestShowingsList;
        public event Action<int> RequestSeatsList;
        public event Action<BookSeatsRequest> RequestBookShowing;

        public void ShowBookingsList(BookingResponse[] response)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(bool success, string message)
        {
            throw new NotImplementedException();
        }

        public void ShowSeatsList(SeatToChooseResponse[] response)
        {
            throw new NotImplementedException();
        }

        public void ShowShowingsList(ShowingResponse[] response)
        {
            throw new NotImplementedException();
        }
    }
}
