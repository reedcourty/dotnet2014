using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace pomodoro
{
    public class Tracer
    {
        private TraceSource ts = new TraceSource("Pomodoro");

        public Tracer()
        {
            SourceSwitch sourceSwitch = new SourceSwitch("SourceSwitch", "Verbose");
            ts.Switch = sourceSwitch;

            ConsoleTraceListener consoleListener = new ConsoleTraceListener();
            consoleListener.Name = "console";
            consoleListener.TraceOutputOptions = TraceOptions.DateTime | TraceOptions.ProcessId | TraceOptions.ThreadId;

            ts.Listeners.Add(consoleListener);

            FileStream traceLog = new FileStream(@"pomodoro.log", FileMode.OpenOrCreate);

            TextWriterTraceListener fileListener = new TextWriterTraceListener(traceLog);
            fileListener.Name = "log";
            fileListener.TraceOutputOptions = TraceOptions.DateTime | TraceOptions.ProcessId | TraceOptions.ThreadId;

            ts.Listeners.Add(fileListener);
        }

        public void PutEvent(TraceEventType eventType, int id, string message)
        {
            ts.TraceEvent(eventType, id, message);
            ts.Flush();
        }

        public void putInfo(int id, string message)
        {
            ts.TraceEvent(TraceEventType.Information, id, message);
            ts.Flush();
        }

        public void putError(int id, string message)
        {
            ts.TraceEvent(TraceEventType.Error, id, message);
            ts.Flush();
        }

        public void PutSQLQuery(SQLiteCommand cmd, int id)
        {
            string query = cmd.CommandText;

            foreach (SQLiteParameter p in cmd.Parameters)
            {
                query = query.Replace(p.ParameterName, String.Format("'{0}'", p.Value.ToString()));
            }

            ts.TraceEvent(TraceEventType.Information, id, query);
            ts.Flush();
        }

        public void Close()
        {
            ts.Close();
        }
    }
}
