using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinowySystemRezerwacji.service;
using KinowySystemRezerwacji.view;

namespace KinowySystemRezerwacji
{
    static class Program
    {
        /// <summary>
        /// Główny punkt startowy aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Service model = new Service();

            model.LogIn("dupa", "dupa");
            model.BookSeats(new dto.BookSeatsRequest()
            {
                ShowingId = 22,
                SeatsIds = new int[] { 115, 116, 117 }
            });

            IView view = new ViewManager();
            Presenter presenter = new Presenter(model, view);

            while (true)
            {
                Form activeForm = (((ViewManager)view)).GetActiveForm();
                if (activeForm != null)
                {
                    Application.Run(activeForm);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
