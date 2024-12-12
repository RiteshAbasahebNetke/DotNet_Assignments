using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEX
{
    class Product
    {
        public int ProductID;
        public string ProductName;
        public string MfgName;
        public decimal Price;

        public void AddProduct(int pi,string pn,string mn,decimal pr)
        {
            this.ProductID = pi;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = pr;
        }
        public void DispProduct()
        {
            Console.WriteLine("ProductID:"+ this.ProductID);
            Console.WriteLine("Product Name:"+ this.ProductName);
            Console.WriteLine("Mfg Name:"+ this.MfgName);
            Console.WriteLine("Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] p = new Product[3];

            int pid;
            string pn, mn;
            decimal pr;

            for(int i=0; i<3; i++)
            {
                Console.Write("Enter ProductID:");
                pid=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name:");
                pn=Console.ReadLine();

                Console.Write("Enter Mfg Name:");
                mn=Console.ReadLine();

                Console.Write("Enter Price:");
                pr = Convert.ToInt32(Console.ReadLine());

                p[i] = new Product();
                p[i].AddProduct(pid, pn, mn, pr);
            }
            Console.WriteLine();

            /*for(int i=0; i<3;i++)
            {
                p[i].DispProduct();
            }*/

            for(int i=0;i<3;i++)
            {
                if (p[i].Price>500)
                {
                    p[i].DispProduct();
                }
            }
        }
    }
}
