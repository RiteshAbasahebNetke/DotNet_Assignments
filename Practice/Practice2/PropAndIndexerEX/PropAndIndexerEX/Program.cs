using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropAndIndexerEX
{
    class Product
    {
        public int ProductID;
        public string ProductName;
        public string MfgName;
        public double Price;

        public double ProPrice
        {
            get { return Price; }
        }
        public Product(int pid,string pn,string mn,double p)
        {
            this.ProductID = pid;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = p;
        }
        public void DispProduct()
        {
            Console.WriteLine("ProductID:"+ this.ProductID);
            Console.WriteLine("Product Name:"+ this.ProductName);
            Console.WriteLine("Mfg Name:"+ this.MfgName);
            Console.WriteLine("Price:"+ this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pr = new List<Product>();
            int pid;
            string pn, mn;
            double p;
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter ProductID:");
                pid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Product Name:");
                pn = Console.ReadLine();

                Console.Write("Enter Mfg Name:");
                mn = Console.ReadLine();

                Console.Write("Enter Price:");
                p = Convert.ToDouble(Console.ReadLine());

                pr.Add(new Product(pid,pn, mn, p));
            }
            foreach(var temp in pr)
            {
                if(temp.ProPrice>1000)
                {
                    temp.DispProduct();
                }
            }
        }
    }
}
