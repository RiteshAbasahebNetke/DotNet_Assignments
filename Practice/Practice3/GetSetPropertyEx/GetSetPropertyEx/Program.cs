using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetPropertyEx
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

        public Product(int pid,string pn,string mn,double pr)
        {
            this.ProductID = pid;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = pr;
        }
        public void DispProduct()
        {
            Console.WriteLine("ProductID:"+ this.ProductID);
            Console.WriteLine("Product Name:"+ this.ProductName);
            Console.WriteLine("Mfg Name:" + this.MfgName);
            Console.WriteLine("Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();
            int pid;
            string pn, mn;
            double pr;

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter ProductID:");
                pid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Product Name:");
                pn=Console.ReadLine();
                Console.Write("Enter Mfg Name:");
                mn = Console.ReadLine();
                Console.WriteLine("Enter Price:");
                pr=Convert.ToInt64(Console.ReadLine());

                p.Add(new Product(pid,pn,mn,pr));
            }
            foreach(var temp in p)
            {
                if(temp.ProPrice>500)
                {
                    temp.DispProduct();
                }
            }
        }
    }
}
