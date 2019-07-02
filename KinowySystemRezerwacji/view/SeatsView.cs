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
        private List<Label> labels;
        private const int SPACES_SIZE = 5;

        public SeatsView()
        {
            InitializeComponent();
        }

        internal SeatToChooseResponse[] Seats
        {
            set
            {
                labels = new List<Label>();
                foreach (SeatToChooseResponse seat in value)
                {
                    Label label = new Label();

                    label.Height;
                    label.Width;
                    label.BackColor;
                    label.Top;
                    label.Left;

                    labels.Add(label);
                }
            }
        }

    }
}
