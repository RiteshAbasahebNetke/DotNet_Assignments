using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProductEX
{
    class Product
    {
        private int ProductID;
        private string ProductName;
        private string MfgName;
        private double Price;

        public double propPrice
        {
            get { return Price; }
        }

        public Product(int pid, string pn, string mn, double p)
        {
            this.ProductID= pid;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = p;
        }
        public void dispProduct()
        {
            Console.WriteLine("ProductID:" + this.ProductID);
            Console.WriteLine("ProductName:" + this.ProductName);
            Console.WriteLine("MfgName:" + this, MfgName);
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

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter ProductID:");
                pid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter ProductName:");
                pn = Console.ReadLine();

                Console.Write("Enter MfgName:");
                mn = Console.ReadLine();

                Console.WriteLine("Enter Price:");
                p = Convert.ToDouble(Console.ReadLine());

                pl.Add(new Product(pid, pn, mn, p));
            }
            Console.WriteLine("*************Product Detail:***************");
            foreach(Product temp in pl)
            {
                if(temp.propPrice>500)
                {
                    temp.dispProduct();
                }
            }
        }
    }
}
