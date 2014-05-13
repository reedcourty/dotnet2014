using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro
{
    class Tracer
    {
        TraceSource ts = new TraceSource("Pomodoro");

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

        public void Close()
        {
            ts.Close();
        }
    }
}
