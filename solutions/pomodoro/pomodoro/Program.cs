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

            ConfigManager cm = new ConfigManager();
            cm.Init();

            DataManager dm = new DataManager { DB = cm.Configuration.DbFile };
            dm.createDBOrSkip();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(dm));
        }

        // TODO: Beállítások létrehozása, exportálása első indításkor
        // TODO: Beállítások beolvasása
        
        // TODO: Napló exportálása XLS-be
    }
}
