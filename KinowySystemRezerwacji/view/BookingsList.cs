using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinowySystemRezerwacji.dto;

namespace KinowySystemRezerwacji.view
{
    public partial class BookingsList : UserControl
    {
        public BookingsList()
        {
            InitializeComponent();
        }

        internal BookingResponse[] Bookings
        {
            set
            {
                bookingsListBox.Items.Clear();
                foreach (BookingResponse booking in value)
                {
                    bookingsListBox.Items.Add($"Film: {booking.FilmName}, data: {booking.DateTime}, miejsc: {booking.Seats.Length}");
                }
            }
        }
    }
}
