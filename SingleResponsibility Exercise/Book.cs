using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Exercise
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string ISBN { get; set; }

        public Book(string name, string authorName, int year, int price, string iSBN)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            AuthorName = authorName ?? throw new ArgumentNullException(nameof(authorName));
            Year = year;
            Price = price;
            ISBN = iSBN ?? throw new ArgumentNullException(nameof(iSBN));
        }
    }
}
