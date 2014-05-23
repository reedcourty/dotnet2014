using pomodoro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteMigrator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init:
            Tracer tracer = new Tracer();

            tracer.PutEvent(TraceEventType.Information, 1, "SQLiteMigrator has been started...");

            ConfigManager cm = new ConfigManager(tracer);

            DataManager dm = new DataManager { DB = cm.Configuration.DbFile };
            dm.tracer = tracer;
            dm.createMSSQLDBNoMatterWhat();
            dm.migrateSQLiteToMSSQL();

            Console.ReadLine();

            tracer.Close();
        }
    }
}
