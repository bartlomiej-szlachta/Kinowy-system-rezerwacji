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

            bookingsListBox.Left = (ClientSize.Width - bookingsListBox.Width) / 2;
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

        public void ShowBookingsList(BookingResponse[] response)
        {
            bookingsListBox.Bookings = response;
        }

        public void ShowSeatsList(SeatToChooseResponse[] response)
        {
            throw new NotImplementedException();
        }

        public void ShowShowingsList(ShowingResponse[] response)
        {
            throw new NotImplementedException();
        }

        private void wylogujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RequestLogOut?.Invoke();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //RequestBookingsList?.Invoke();
            BookingResponse[] response = new BookingResponse[]
            {
                new BookingResponse()
                {
                    FilmName = "Shrek",
                    DateTime = new DateTime(2019, 06, 30, 12, 0, 0),
                    Seats = new BookedSeatResponse[]
                    {
                        new BookedSeatResponse()
                        {
                            PosX = 4,
                            PosY = 6
                        },
                        new BookedSeatResponse()
                        {
                            PosX = 4,
                            PosY = 7
                        }
                    }
                },
                new BookingResponse()
                {
                    FilmName = "Miss marca",
                    DateTime = new DateTime(2019, 07, 02, 17, 0, 0),
                    Seats = new BookedSeatResponse[]
                    {
                        new BookedSeatResponse()
                        {
                            PosX = 6,
                            PosY = 10
                        },
                        new BookedSeatResponse()
                        {
                            PosX = 7,
                            PosY = 10
                        },
                        new BookedSeatResponse()
                        {
                            PosX = 8,
                            PosY = 10
                        }
                    }
                },
                new BookingResponse()
                {
                    FilmName = "Moonlight",
                    DateTime = new DateTime(2019, 07, 04, 12, 0, 0),
                    Seats = new BookedSeatResponse[]
                    {
                        new BookedSeatResponse()
                        {
                            PosX = 6,
                            PosY = 9
                        }
                    }
                }
            };
        
            

            ShowBookingsList(response);
        }
    }
}
