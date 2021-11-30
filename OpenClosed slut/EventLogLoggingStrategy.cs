using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_slut
{
    public class EventLogLoggingStrategy : ILoggingStrategy
    {
        public void Log(string message)
        {
            string source = "DNC Magazine";
            string log = "Application";

            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, log);
            }
            EventLog.WriteEntry(source, message, EventLogEntryType.Error, 1);
        }
    }
}
