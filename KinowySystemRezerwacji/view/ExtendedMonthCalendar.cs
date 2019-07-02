using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinowySystemRezerwacji.view
{
    public partial class ExtendedMonthCalendar : UserControl
    {
        /// <summary>
        /// Konstruktor.
        /// </summary>
        public ExtendedMonthCalendar()
        {
            InitializeComponent();
            monthCalendar.MinDate = DateTime.Now;
        }


    }
}
