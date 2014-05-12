using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodoro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TODO: Adatbázis létrehozása első indításkor, config fájl alapján

            // Init:
            DataManager dm = new DataManager { DB = "pomodoro.db" };
            dm.createDBOrSkip();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        // TODO: Beállítások létrehozása, exportálása első indításkor
        // TODO: Beállítások beolvasása
        
        // TODO: Napló exportálása XLS-be
    }
}
