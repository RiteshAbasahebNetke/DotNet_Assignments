using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjectBookEX
{
    internal class Book
    {
        private int BookID;
        private string BookName;
        private string AuthorName;
        public double Price;

        public void AddBook(int bi,string bn,string an,double p)
        {
            this.BookID = bi;
            this.BookName = bn;
            this.AuthorName = an;
            this.Price = p;
        }
        public void DispBook()
        {
            Console.WriteLine("BookID:" + this.BookID);
            Console.WriteLine("BookName:" + this.BookName);
            Console.WriteLine("AuthorName:"+ this.AuthorName);
            Console.WriteLine("Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] b = new Book[3];
            int bi;
            string bn, an;
            double p;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter BookID:");
                bi = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter BookName:");
                bn = Console.ReadLine();

                Console.Write("Enter AuthorName:");
                an = Console.ReadLine();

                Console.Write("Enter Price:");
                p = Convert.ToDouble(Console.ReadLine());

                b[i] = new Book();
                b[i].AddBook(bi,bn,an,p);
                Console.WriteLine();
            }
            for(int i=0; i < 3; i++)
            {
                if (b[i].Price>500)
                {
                    b[i].DispBook();
                }
            }
        }
    }
}
