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
    public partial class ActiveForm : Form, IView
    {
        public ActiveForm()
        {
            InitializeComponent();
        }

        public event Action RequestBookingsList;
        public event Action<BookSeatsRequest> RequestBookShowing;
        public event Action<string, string> RequestLogIn;
        public event Action RequestLogOut;
        public event Action<RegisterRequest> RequestRegister;
        public event Action<int> RequestSeatsList;
        public event Action<DateTime> RequestShowingsList;

        public void LoggingInCompleted(string username)
        {
            throw new NotImplementedException();
        }

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
