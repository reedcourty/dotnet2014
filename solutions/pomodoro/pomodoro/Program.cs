using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            // Init:
            Tracer tracer = new Tracer();
            
            tracer.PutEvent(TraceEventType.Information, 1, "Pomodoro has been started...");

            ConfigManager cm = new ConfigManager(tracer);
            //cm.Init();

            DataManager dm = new DataManager { DB = cm.Configuration.DbFile};
            dm.createDBOrSkip();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(dm));

            tracer.Close();
        }  
    }
}
