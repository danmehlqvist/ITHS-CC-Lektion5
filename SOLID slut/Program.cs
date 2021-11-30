// See https://aka.ms/new-console-template for more information
using ITHS_CC_Lektion5;
using SOLID_slut;


CsvFileProcessor csvFileProcessor = new(
    new FileProvider("test"),
    new CsvParser(),
    new DatabaseSaver("server=(local);integrated security=sspi;database=SRP")
    );
csvFileProcessor.Process();