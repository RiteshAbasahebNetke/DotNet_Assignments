
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEX
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public double Price { get; set; }

        public void AddProduct(int pid,string pn,string mn,double pr)
        {
            this.ProductID = pid;
            this.ProductName = pn;
            this.MfgName = mn;
            this.Price = pr;
        }

        public void DispProduct()
        {
            Console.WriteLine("ProductID:" + this.ProductID);
            Console.WriteLine("Product Name:"+ this.ProductName);
            Console.WriteLine("Mfg Name:" + this.MfgName);
            Console.WriteLine("Price:"+ this.Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p=new Product();
            p.AddProduct(1, "Mouse", "Intex", 450);
            p.DispProduct();
        }
    }
}
