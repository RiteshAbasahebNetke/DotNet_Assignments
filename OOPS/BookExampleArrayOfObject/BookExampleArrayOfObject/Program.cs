using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExampleArrayOfObject
{
    public class Book
    {
        public int BookID;
        public string BookName;
        public string AuthorName;
        public double Price;

        public void AddBook(int bi, string bn, string an, double p)
        {
            this.BookID = bi;
            this.BookName = bn;
            this.AuthorName = an;
            this.Price = p;
        }

        public void DispBook()
        {
            Console.WriteLine("BookID is:" + this.BookID);
            Console.WriteLine("BookName is:" + this.BookName);
            Console.WriteLine("Author Name is:" + this.AuthorName);
            Console.WriteLine("Price is:"+ this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book [] b = new Book[5];
            int bi;
            string an, bn;
            double p;
            for(int i=0; i<5;i++)
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
                b[i].AddBook(bi, bn, an, p);
                Console.WriteLine();
            }
            for(int i=0; i<5;i++)
            {
                if (b[i].Price >2000)
                {
                    b[i].DispBook();
                }
            }
        }
    }
}
