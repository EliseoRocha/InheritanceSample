using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Software s = new Software("9-Tap Bowling")
            {
                Price = 9.99,
                Company = "Joe Soft"
            };

            Product p = new Product("Gadget")
            {
                Price = 1.99
            };

            Book b = new Book("C# is fun")
            {
                Price = 9.99,
                Isbn = "123456789"
            };

            ShowProduct(p);
            ShowProduct(s);
            ShowProduct(b);
            Console.ReadKey();
        }

        private static void ShowProduct(Product p)
        {
            Console.WriteLine(p.GetDisplayText("\n"));

            //see if the product is a book, if true, print publisher
            if (p is Book)
            {
                Book currBook = p as Book; //p as Book is casting
                Console.WriteLine(currBook.Publisher);

                //same as above but condensed
                //Console.WriteLine((p as Book).Publisher);
                //Console.WriteLine(((Book)p).Publisher);
            }

            Console.WriteLine();
        }
    }
}
