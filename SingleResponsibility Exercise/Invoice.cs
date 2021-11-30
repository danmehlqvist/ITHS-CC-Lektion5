using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Exercise
{
    public class Invoice
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public double DiscountRate { get; set; }
        public double TotalPrice => CalculateInvoiceTotalPrice();

        public Invoice(Book book, int quantity, double discountRate)
        {
            Book = book;
            Quantity = quantity;
            DiscountRate = discountRate;
        }

        public void ProcessInvoice()
        {
            Console.WriteLine(Quantity + "x " + Book.Name + " " + Book.Price + "$");
            Console.WriteLine("Discount Rate: " + DiscountRate);
            Console.WriteLine("Total: " + TotalPrice);
            

            this.SaveInvoiceToFile("filename");
        }

        private void SaveInvoiceToFile(string filename)
        {
            // Logik för att spara ner i en fil. Behöver inte implmenteras.
        }

        private double CalculateInvoiceTotalPrice()
        {
            double totalPriceBeforeDiscount = Book.Price * Quantity;
            double totalPriceAfterDiscount = totalPriceBeforeDiscount * (1 - DiscountRate);
            return totalPriceAfterDiscount;
        }
    }
}
