using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectEx
{
    class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public void DispProduct()
        {
            Console.WriteLine("ProductID:" + this.ProductID);
            Console.WriteLine("Product Name:" + this.ProductName);
            Console.WriteLine("Mfg Name:"+ this.MfgName);
            Console.WriteLine("Price:" + this.Price);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pl = new List<Product>();
            pl.Add(new Product() { ProductID = 1, ProductName = "Monitor", MfgName = "Dell", Price = 8790 });
            pl.Add(new Product() { ProductID = 2, ProductName = "Mouse", MfgName = "Intex", Price = 560 });
            pl.Add(new Product() { ProductID = 3, ProductName = "Charger", MfgName = "Mi", Price = 780 });
            pl.Add(new Product() { ProductID = 4, ProductName = "Mobile Phone", MfgName = "Samsung", Price = 9999 });
            pl.Add(new Product() { ProductID = 5, ProductName = "HardDisk", MfgName = "Seggate", Price = 4560 });

            //var v = from m in pl select m;

            //var v = from m in pl where m.MfgName=="Dell" select m;

            /*var v = from m in pl where m.Price > 5000 select m;*/

            /*var v=from m in pl orderby m.Price select m;*/

            /*foreach(var temp in v)
            {
                temp.DispProduct();
            }*/

            var v = from m in pl orderby m.Price descending select m;

            foreach(var temp in v)
            {
               Console.WriteLine("Mfg Name:"+ temp.MfgName);
                Console.WriteLine("Price:"+ temp.Price);
            }
        }
    }
}
