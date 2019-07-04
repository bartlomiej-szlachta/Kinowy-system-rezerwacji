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

        internal int ShowingId { private get; set; }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            List<int> chosenIds = new List<int>();
            foreach (Label label in seatsPanel1.Labels)
            {
                if (label.BackColor == Color.Yellow)
                {
                    Int32.TryParse(label.Name, out int id);
                    chosenIds.Add(id);
                }
            }
            if (chosenIds.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego miejsca", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                BookSeatsRequest request = new BookSeatsRequest
                {
                    ShowingId = ShowingId
                };
                request.SeatsIds = chosenIds.ToArray();

                RequestBookShowing.Invoke(request);

                foreach (Label label in seatsPanel1.Labels)
                {
                    seatsPanel1.Controls.Remove(label);
                }
                Visible = false;
            }
        }
    }
}
