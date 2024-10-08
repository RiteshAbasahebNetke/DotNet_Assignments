using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookObjectEx
{
    internal class book
    {
        int BookID;
        string BookName;
        string AuthorName;
        public double Price;

        public void AddBook(int bid,string bn,string an,double p)
        {
            this.BookID = bid;
            this.BookName = bn;
            this.AuthorName = an;
            this.Price = p;
        }

        public void DispBook()
        {
            Console.WriteLine("Enter BookID:" + this.BookID);
            Console.WriteLine("Enter BookName:" + this.BookName);
            Console.WriteLine("Enter AuthorName:" + this.AuthorName);
            Console.WriteLine("Enter Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book [] b = new book [3];
            int bid;
            string bn;
            string an;
            double p;

            for(int i=0; i<3; i++)
            {
                Console.Write("Enter BookID:");
                bid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter BookName:");
                bn=Console.ReadLine();
                Console.Write("Enter AuthorName:");
                an=Console.ReadLine();
                Console.Write("Enter Price");
                p=Convert.ToInt32(Console.ReadLine());

                b[i] = new book();
                b[i].AddBook(bid, bn, an, p);
                Console.WriteLine();
            }
            for(int i=0; i<3; i++)
            {
                if (b[i].Price>2000)
                {
                    b[i].DispBook();
                }
            }
        }
    }
}
