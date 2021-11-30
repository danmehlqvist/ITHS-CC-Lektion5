using SingleResponsibility_Exercise;

Book book = new Book(
    "The C programming guide",
    "Dennis Rithie / Brian Kernighan",
    1988,
    100,
    "9780131103627");



Invoice invoice = new Invoice(book,1,0);

invoice.ProcessInvoice();