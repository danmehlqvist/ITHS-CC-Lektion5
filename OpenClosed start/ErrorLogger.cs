using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_start
{
    public class ErrorLogger
    {
        private readonly string _whereToLog;
        public ErrorLogger(string whereToLog)
        {
            _whereToLog = whereToLog.ToUpper();
        }

        public void LogError(string message)
        {
            switch (_whereToLog)
            {
                case "TEXTFILE":
                    WriteTextFile(message);
                    break;
                case "EVENTLOG":
                    WriteEventLog(message);
                    break;
                default:
                    throw new Exception("Unable to log error");
            }
        }

        private void WriteTextFile(string message)
        {
            // Vi behöver inte gå ner och skriva på hårddisken för detta exempel.
            //File.WriteAllText(@"C:\Temp\Errors.txt", message);
        }

        private void WriteEventLog(string message)
        {
            // Vi behöver inte lägga till saker i vår EventLog.
            // Det kommer dessutom troligen inte fungera på Mac-maskiner. 
            
            //string source = "Clean code";
            //string log = "Application";

            //if (!EventLog.SourceExists(source))
            //{
            //    EventLog.CreateEventSource(source, log);
            //}
            //EventLog.WriteEntry(source, message, EventLogEntryType.Error, 1);
        }
    }
}
