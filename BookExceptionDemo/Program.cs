using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] aBook = new Book[4];
            
            for(int y = 0; y < aBook.Length; ++y)
            {
                aBook[y] = new Book("x", "x", 2, 2);
            }

            try
            {
                aBook[0].title = "Dark Magic"; aBook[0].author = "Robert, Nancy"; aBook[0].price = 1899; aBook[0].pages = 275;
                aBook[1].title = "In The Rain"; aBook[1].author = "Lee, Ashley"; aBook[1].price = 990; aBook[1].pages = 100;
                aBook[2].title = "Act"; aBook[2].author = "Russel, Dan"; aBook[2].price = 1566; aBook[2].pages = 175;
                aBook[3].title = "In The Rain"; aBook[3].author = "Ray, Paul"; aBook[3].price = 299; aBook[3].pages = 28;

                int x = 0;

                while(x < 4)
                {
                    if((aBook[x].pages * 10) < aBook[x].price)
                    {
                        BookException nbe = new BookException(aBook[x].title, aBook[x].pages, aBook[x].price * .01);
                        throw (nbe);
                    }
                    ++x;
                }
            }
            catch(BookException e)
            {
                WriteLine(e.Message);
            }

            double price1 = aBook[0].price * .01;
            double price2 = aBook[1].price * .01;
            double price3 = aBook[2].price * .01;
            double price4 = aBook[3].price * .01;

            WriteLine();
            WriteLine(" The book {0} by {1} contains {2} pages and will cost {3}.", aBook[0].title, aBook[0].author, 
                aBook[0].pages, price1.ToString("C"));
            WriteLine();
            WriteLine();
            WriteLine(" The book {0} by {1} contains {2} pages and will cost {3}.", aBook[1].title, aBook[1].author,
                aBook[1].pages, price2.ToString("C"));
            WriteLine();
            WriteLine();
            WriteLine(" The book {0} by {1} contains {2} pages and will cost {3}.", aBook[2].title, aBook[2].author,
                aBook[2].pages, price3.ToString("C"));
            WriteLine();
            WriteLine();
            WriteLine(" The book {0} by {1} contains {2} pages and will cost {3}.", aBook[3].title, aBook[3].author,
                aBook[3].pages, price4.ToString("C"));

            ReadLine();
          
        }
    }
    class Book
    {
        public string title
        { get; set; }
        public string author
        { get; set; }
        public double price
        { get; set; }      
        public int pages
        { get; set; }
 

        public Book(string Title, string Author, double Price, int Pages)
        {
            title = Title;
            author = Author;
            price = Price;
            pages = Pages;

        }

    }
    class BookException : Exception
    {
        private static string msg = " The price of this book is invalid ";
        public BookException(string aTitle, int aPrice, double aPages)
            : base(msg)
        {
            WriteLine(" The book {0} cost {1} for {2} pages, which is invalid.", aTitle, aPrice.ToString("C2"), aPages);
        }
    }
}
