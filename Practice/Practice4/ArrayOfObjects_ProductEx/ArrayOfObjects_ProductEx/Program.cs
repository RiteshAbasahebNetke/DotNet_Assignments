using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfObjects_ProductEx
{
    class Product
    {
        public int ProductID;
        public string ProductName;
        public string MfgName;
        public double Price;

        public void AddProduct(int pi,string pn,string mn,double pr)
        {
            this.ProductID = pi;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = pr;
        }
        public void DispProduct()
        {
            Console.WriteLine("Product ID:" + this.ProductID);
            Console.WriteLine("Product Name:"+ this.ProductName);
            Console.WriteLine("Mfg Name:" + this.MfgName);
            Console.WriteLine("Price:"+ this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] p = new Product[3];

            int pi;
            string pn,mn;
            double pr;

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter ProductID:");
                pi=Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name:");
                pn=Console.ReadLine();

                Console.Write("Enter Mfg Name:");
                mn=Console.ReadLine();

                Console.Write("Enter Price:");
                pr=Convert.ToDouble(Console.ReadLine());

                p[i] = new Product();
                p[i].AddProduct(pi,pn,mn,pr);
            }

            Console.WriteLine();
            for(int i=1;i<4;i++)
            {
                if (p[i].Price>1000)
                {
                    p[i].DispProduct();
                }
            }
        }
    }
}
