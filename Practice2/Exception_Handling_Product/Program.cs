using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Product
{
    class Price : Exception
    {
        private string ExMessage;
        public Price(string exMessage)
        {
            ExMessage = exMessage;
        }
        public void dispPriceException()
        {
            Console.WriteLine("########### Price Exception Occured ###########");
        }
    }
    class Product
    {
        private int Productid;
        private string ProductName;
        private string MfgName;
        private double Price;

        public void addProduct(int pid,string pn,string mn, double p)
        {
            if (p <= 0)
            {
                throw new Price("Price can not be less than zero");
            }
            this.Productid = pid;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = p;
        }
        public void dispProduct()
        {
            Console.WriteLine("Product ID:" + this.Productid);
            Console.WriteLine("Product Name:" + this.ProductName);
            Console.WriteLine("Mfg Name:" + this.MfgName);
            Console.WriteLine("Price:" + this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            try
            {
                p.addProduct(1, "Desktop", "iBall", -50);
                p.dispProduct();
            }
            catch(Price pc)
            {
                pc.dispPriceException();
            }
        }
    }
}
