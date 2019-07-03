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
    internal partial class ShowingsListBox : UserControl
    {
        List<ShowingResponse> sramNaWinFormsy = new List<ShowingResponse>();


        internal ShowingsListBox()
        {
            InitializeComponent();
        }

        internal event Action<int> RequestSeatsList;

        internal ShowingResponse[] Showings
        {
            set
            {
                listBoxShowings.Items.Clear();
                foreach (ShowingResponse showing in value)
                {
                    listBoxShowings.Items.Add($"ID: {showing.Id} Tytuł: {showing.FilmName}, data seansu: {showing.DateTime}, czas trwania: {showing.FilmDuration}, rok premiery: {showing.FilmYear}");
                    sramNaWinFormsy.Add(showing);
                }
            }
        }

        private void ShowingsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RequestSeatsList?.Invoke(sramNaWinFormsy[listBoxShowings.SelectedIndex].Id);
        }
    }
}
