using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Microsoft.FSharp.Core;
using System.Runtime.InteropServices;

namespace pomodoro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern uint NtQuerySystemTime(out long SystemTime);

        [STAThread]
        static void Main()
        {

            long t;
            NtQuerySystemTime(out t);

            // TODO: Performance Counters
            //      http://msdn.microsoft.com/en-us/library/vstudio/system.diagnostics.performancecounter
            //      http://msdn.microsoft.com/en-us/library/w8f5kw2e(v=vs.110).aspx
            //      http://msdn.microsoft.com/en-us/library/9tyc2s04(v=vs.110).aspx
            //      http://msdn.microsoft.com/en-us/library/w4bz2147(v=vs.110).aspx

            // Init:
            Tracer tracer = new Tracer();

            tracer.PutEvent(TraceEventType.Information, 1, String.Format("Pomodoro has been started at {0}...", DateTime.FromFileTime(t).ToString()));

            ConfigManager cm = new ConfigManager(tracer);

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cm.Configuration.Language);

            tracer.PutEvent(TraceEventType.Information, 1, String.Format("Language: {0}", cm.Configuration.Language));

            DataManager dm = new DataManager { DB = cm.Configuration.DbFile };
            dm.tracer = tracer;

            dm.createDBOrSkip();

            tracer.PutEvent(TraceEventType.Information, 42, String.Format("Number of tags in DB: {0}", Pomodoro.Stat.SQLDataConnection.SQLDataConnection.tag_num));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(dm, cm));

            tracer.Close();
        }  
    }
}
