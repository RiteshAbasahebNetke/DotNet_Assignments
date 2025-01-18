using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEx
{
    internal class Book
    {
        private int BookId;
        private string BookName;
        private string AuthorName;
        private decimal Price;

        public void AddBook(int bi,string bn,string an,decimal p)
        {
            BookId = bi;
            BookName = bn;
            AuthorName = an;
            Price = p;
        }
        public void DispBook()
        {
            Console.WriteLine("BookID:" + BookId);
            Console.WriteLine("BookName:" + BookName);
            Console.WriteLine("AuthorName:" + AuthorName);
            Console.WriteLine("Price:" + Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.AddBook(1, "BalBharti", "Pune Board", 45);
            b.DispBook();
        }
    }
}
