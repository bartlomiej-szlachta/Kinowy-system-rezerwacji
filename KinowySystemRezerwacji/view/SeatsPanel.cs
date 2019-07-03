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
    public partial class SeatsPanel : UserControl
    {

        public List<Label> Labels { get; set; }
        private const int SPACES_SIZE = 5;

        public SeatsPanel()
        {
            InitializeComponent();
        }

        internal SeatToChooseResponse[] Seats
        {
            set
            {
                Labels?.Clear();
                Labels = new List<Label>();

                int suggestedLabelWidth = (Width - 13 * SPACES_SIZE) / 12;
                int suggestedLabelHeight = (Height - 11 * SPACES_SIZE) / 10;
                int labelSize;
                int diffTop = 0;
                int diffLeft = 0;
                if (suggestedLabelWidth < suggestedLabelHeight)
                {
                    labelSize = suggestedLabelWidth;
                    diffTop = (Height - 10 * labelSize - 9 * SPACES_SIZE) / 2;
                }
                else
                {
                    labelSize = suggestedLabelHeight;
                    diffLeft = (Width - 12 * labelSize - 11 * SPACES_SIZE) / 2;
                }

                foreach (SeatToChooseResponse seat in value)
                {
                    Label label = new Label
                    {
                        Name = seat.Id.ToString(),
                        Height = labelSize,
                        Width = labelSize,
                        BackColor = seat.Available ? Color.Green : Color.Red,
                        Top = diffTop + SPACES_SIZE + (seat.PosY - 1) * (labelSize + SPACES_SIZE),
                        Left = diffLeft + SPACES_SIZE + (seat.PosX - 1) * (labelSize + SPACES_SIZE),
                        Anchor = AnchorStyles.None
                    };
                    
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

                    Labels.Add(label);
                }

                Controls.AddRange(Labels.ToArray());
            }
        }
    }
}
