using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPatterns.TracingLogging
{
    public class LoggerWorker
    {
        public void StartLoggerService()
        {
            TraceSource ts = new TraceSource("Peters log", SourceLevels.All);
            ts.Switch = new SourceSwitch("Log", SourceLevels.All.ToString());

            ts.Listeners.Add(new ConsoleTraceListener());

            TraceListener txtListener = new TextWriterTraceListener("peterslog.txt");
            txtListener.Filter = new EventTypeFilter(SourceLevels.Critical);
            ts.Listeners.Add(txtListener);

            ts.Listeners.Add(new XmlWriterTraceListener("peterslog.xml"));


            // til event log
            TraceListener eventListener = new EventLogTraceListener("Application");
            ts.Listeners.Add(eventListener);

            // i stedet for console writeline
            ts.TraceEvent(TraceEventType.Information, 8, "information");
            ts.TraceEvent(TraceEventType.Warning, 8, "warning");
            ts.TraceEvent(TraceEventType.Error, 8, "error");
            ts.TraceEvent(TraceEventType.Critical, 8, "critical");



            ts.Close();
        }
    }
}
