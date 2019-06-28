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
            IView view = new ViewManager();
            Presenter presenter = new Presenter(model, view);

            view.Run((IView viewObject) => Application.Run((Form)(ViewManager)viewObject));
        }
    }
}
