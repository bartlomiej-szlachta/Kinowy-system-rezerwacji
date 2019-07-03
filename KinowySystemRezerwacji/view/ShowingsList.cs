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
    /// <summary>
    /// Komponent zawierający listę do wyboru seansu.
    /// </summary>
    internal partial class ShowingsList : UserControl
    {
        /// <summary>
        /// Konstruktor.
        /// </summary>
        internal ShowingsList()
        {
            InitializeComponent();
        }

        internal event Action<int> RequestSeatsList;

        /// <summary>
        /// Właściwość.
        /// </summary>
        internal ShowingResponse[] Showings
        {
            set
            {
                showingsListView.Clear();
                foreach (var showingItem in value)
                {
                    ListViewItem listItem = new ListViewItem(showingItem.Id.ToString());
                    listItem.SubItems.Add(showingItem.FilmName);
                    listItem.SubItems.Add(showingItem.DateTime.TimeOfDay.ToString());
                    listItem.SubItems.Add(showingItem.FilmYear.ToString());
                    listItem.SubItems.Add(showingItem.FilmDuration.ToString());
                    showingsListView.Items.Add(listItem);
                }
            }
        }

        /// <summary>
        /// Po podwójnym kliknięciu w kontrolkę, wywołuje się event z przekazaniem id seansu.
        /// </summary>
        private void showingsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RequestSeatsList?.Invoke(Int32.Parse(showingsListView.SelectedItems[0].Text));
        }
    }
}
