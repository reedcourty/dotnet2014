using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
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
            // TODO: Performance Counters
            //      http://msdn.microsoft.com/en-us/library/vstudio/system.diagnostics.performancecounter
            //      http://msdn.microsoft.com/en-us/library/w8f5kw2e(v=vs.110).aspx
            //      http://msdn.microsoft.com/en-us/library/9tyc2s04(v=vs.110).aspx
            //      http://msdn.microsoft.com/en-us/library/w4bz2147(v=vs.110).aspx

            // Init:
            Tracer tracer = new Tracer();
            
            tracer.PutEvent(TraceEventType.Information, 1, "Pomodoro has been started...");

            ConfigManager cm = new ConfigManager(tracer);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cm.Configuration.Language);

            tracer.PutEvent(TraceEventType.Information, 1, String.Format("Language: {0}", cm.Configuration.Language));

            DataManager dm = new DataManager { DB = cm.Configuration.DbFile };
            dm.tracer = tracer;

            dm.createDBOrSkip();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(dm, cm));

            tracer.Close();
        }  
    }
}
