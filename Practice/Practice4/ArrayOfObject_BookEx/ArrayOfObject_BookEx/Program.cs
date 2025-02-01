using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObject_BookEx
{
    class Book
    {
        public int BookID;
        public string BookName;
        public string AuthorName;
        public double Price;

        public void AddProduct(int bi,string bn,string an,double p)
        {
            this.BookID = bi;
            this.BookName = bn;
            this.AuthorName = an;
            this.Price = p;
        }
        public void DispProduct()
        {
            Console.WriteLine("BookID is:"+this.BookID);
            Console.WriteLine("Book Name:"+ this.BookName);
            Console.WriteLine("Author Name:"+ this.AuthorName);
            Console.WriteLine("Price:"+this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book [] b=new Book[3];
            int bi;
            string bn, an;
            double p;

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter BookID:");
                bi=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Book Name:");
                bn=Console.ReadLine();

                Console.Write("Enter Author Name:");
                an=Console.ReadLine();

                Console.Write("Enter Price:");
                p=Convert.ToDouble(Console.ReadLine());

                b[i] = new Book();
                b[i].AddProduct(bi,bn,an,p);
            }
            Console.WriteLine();
            foreach(Book temp in b)
            {
                temp.DispProduct();
            }
            
        }
    }
}
