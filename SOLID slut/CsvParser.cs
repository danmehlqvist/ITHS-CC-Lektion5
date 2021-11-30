using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_slut
{
    internal class CsvParser : IDataParser
    {
        public string[] Parse(string input)
        {
            return input.ToString().Split(new string[] { @"\r\l" }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
