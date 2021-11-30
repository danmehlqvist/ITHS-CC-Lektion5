using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_slut
{
    internal class FileProvider : IDataProvider
    {
        private readonly string _filename;

        public FileProvider(string filename)
        {
            _filename = filename;
        }

        public string Read()
        {
            TextReader tr = new StreamReader(_filename);
            tr.ReadToEnd();
            tr.Close();
            return tr.ToString();
        }

    }
}
