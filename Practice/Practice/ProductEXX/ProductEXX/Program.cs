using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEXX
{
    internal class Program
    {
        class Product
        {
            private int ProductID;
            private string ProductName;
            private string MfgName;
            private double Price;

            public void AddProduct(int pid,string pn,string mn,double p)
            {
                this.ProductID = pid;
                this.ProductName = pn;
                this.MfgName= mn;
                this.Price = p;
            }

            public void DispProduct()
            {
                Console.WriteLine("ProductID" + this.ProductID);
                Console.WriteLine("Product Name:" + this.ProductName);
                Console.WriteLine("Mfg Name:" + this.MfgName);
                Console.WriteLine("Price::" + this.Price);
            }
        }
        static void Main(string[] args)
        {
            Product[] pr = new Product[3];
            int pid;
            string pn, mn;
            double p;
            
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter ProductID:");
                pid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name:");
                pn = Console.ReadLine();

                Console.Write("Enter MfgName:");
                mn= Console.ReadLine();

                Console.Write("Enter Price:");
                p = Convert.ToDouble(Console.ReadLine());

                pr[i] = new Product();
                pr[i].AddProduct(pid, pn, mn, p);
                Console.WriteLine();

            }
            for (int i = 0; i < 3; i++)
            {
                pr[i].DispProduct();
            }
        }
    }
}
