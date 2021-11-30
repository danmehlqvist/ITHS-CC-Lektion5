using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_slut
{
    public class TextFileLoggingStrategy : ILoggingStrategy
    {
        public void Log(string message)
        {
            File.WriteAllText(@"C:\Temp\Errors.txt", message);
        }
    }
}
