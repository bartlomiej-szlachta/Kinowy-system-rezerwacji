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
    public partial class SeatsView : UserControl
    {

        public SeatsView()
        {
            InitializeComponent();
        }

        internal event Action<BookSeatsRequest> RequestBookShowing;

        internal SeatToChooseResponse[] Seats
        {
            set
            {
                seatsPanel1.Seats = value;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            BookSeatsRequest request = new BookSeatsRequest();
            List<int> chosenIds = new List<int>();
            foreach (Label label in seatsPanel1.Labels)
            {
                if (label.BackColor == Color.Yellow)
                {
                    Int32.TryParse(label.Name, out int id);
                    chosenIds.Add(id);
                }
            }
            request.SeatsIds = chosenIds.ToArray();
            seatsPanel1.Labels.Clear();
            RequestBookShowing.Invoke(request);
        }
    }
}
