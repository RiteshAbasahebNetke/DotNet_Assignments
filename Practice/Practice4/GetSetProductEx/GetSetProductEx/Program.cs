using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetProductEx
{
    class Product
    {
        public int ProductID;
        public string ProductName;
        public string MfgName;
        public double Price;

        public double proPrice
        {
            get { return Price; }
        }
        public Product(int pi,string pn,string mn,double p)
        {
            this.ProductID = pi;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = p;
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
            List<Product> pl=new List<Product>();
            int pi;
            string pn, mn;
            double p;

            for(int i=0; i<3;  i++)
            {
                Console.Write("Enter ProductID:");
                pi=Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter ProductName:");
                pn=Console.ReadLine();
                Console.Write("Enter MfgName:");
                mn=Console.ReadLine();
                Console.Write("Enter Price:");
                p=Convert.ToDouble(Console.ReadLine());

                pl.Add(new Product(pi,pn,mn,p));
            }

            Console.WriteLine("**************Product Details**************");
            foreach(var temp in pl)
            {
                if(temp.proPrice>1000)
                {
                    temp.DispProduct();
                }
            }
        }
    }
}
