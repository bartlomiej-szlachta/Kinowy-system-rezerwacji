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
                    int labelSize1 = (Width - 13 * SPACES_SIZE) / 12;
                    int labelSize2 = (Height - 11 * SPACES_SIZE) / 10;
                    int labelSize = labelSize1 < labelSize2 ? labelSize1 : labelSize2;

                    label.Height = labelSize;
                    label.Width = labelSize;
                    label.BackColor;
                    label.Top;
                    label.Left;

                    labels.Add(label);
                }
            }
        }

    }
}
