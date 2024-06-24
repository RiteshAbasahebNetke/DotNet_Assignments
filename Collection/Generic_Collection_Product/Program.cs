using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_Product
{
    class Product
    {
        private int Productid;
        private string ProductName;
        private string Mfgname;
        private double Price;

        public Product(int pid, string pn,string mn, double p)
        {
            this.Productid = pid;
            this.ProductName = pn;
            this.Mfgname = mn;
            this.Price = p;
        }
        public void DispProduct()
        {
            Console.WriteLine("ProductID:" + this.Productid);
            Console.WriteLine("ProductName:" + this.ProductName);
            Console.WriteLine("MfgName:" + this.Mfgname);
            Console.WriteLine("Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pl = new List<Product>();
            int pid;
            string pn, mn;
            double p;
            for(int a = 0; a < 5; a++)
            {
                Console.Write("Enter Productid:");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter ProductName:");
                pn = Console.ReadLine();
                Console.Write("Enter MfgName:");
                mn = Console.ReadLine();
                Console.Write("Enter Price:");
                p = Convert.ToDouble(Console.ReadLine());
                pl.Add(new Product(pid, pn, mn, p));
            }
            Console.WriteLine();
            foreach (Product temp in pl)
            {
              
                temp.DispProduct();
            }
        }
    }
}
