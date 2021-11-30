using SOLID_slut;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Lektion5
{
    public class CsvFileProcessor
    {
        private readonly IDataProvider _dataProvider;
        private readonly IDataParser _parser;
        private readonly IDataSaver _dataSaver;

        public CsvFileProcessor(IDataProvider dataProvider, IDataParser parser, IDataSaver dataSaver)
        {
            _dataProvider = dataProvider;
            _parser = parser;
            _dataSaver = dataSaver;
        }


        public void Process()
        {
            string? data = _dataProvider.Read();

            string[]? parsedData = _parser.Parse(data);

            _dataSaver.Save(parsedData);
        }

        

        
    }
}
