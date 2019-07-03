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
                    label.BackColor = seat.Available ? Color.Green : Color.Red;
                    label.Top = SPACES_SIZE + seat.PosY * (labelSize + SPACES_SIZE);
                    label.Left = SPACES_SIZE + seat.PosX * (labelSize + SPACES_SIZE);

            //        label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));

                    label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                    label.Click += (object sender, EventArgs e) =>
                    {
                        Label theLabel = (Label)sender;
                        if (theLabel.BackColor == Color.Red)
                        {
                            MessageBox.Show("To miejsce jest już zajęte", "Błąd", MessageBoxButtons.OK);
                        }
                        else if (theLabel.BackColor == Color.Green)
                        {
                            theLabel.BackColor = Color.Yellow;
                        }
                        else if (theLabel.BackColor == Color.Yellow)
                        {
                            theLabel.BackColor = Color.Green;
                        }
                    };
                    labels.Add(label);
                }
                Controls.AddRange(labels.ToArray());
            }
        }

    }
}
