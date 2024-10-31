using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectProductEX
{
    class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public double Price { get; set; }

        public void DispProduct()
        {
            Console.WriteLine("ProductID:" + this.ProductID);
            Console.WriteLine("ProductName:"+ this.ProductName);
            Console.WriteLine("MfgName:"+ this.MfgName);
            Console.WriteLine("Price:"+ this.Price);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pl=new List<Product>();
            pl.Add(new Product() { ProductID = 1, ProductName = "USB", MfgName = "Mi", Price = 130 });
            pl.Add(new Product() { ProductID = 2, ProductName = "Monitor", MfgName = "Dell", Price = 7890 });
            pl.Add(new Product() { ProductID = 3, ProductName = "Charger", MfgName = "Apple", Price = 1500 });
            pl.Add(new Product() { ProductID = 4, ProductName = "Printer", MfgName = "HP", Price = 6000 });
            pl.Add(new Product() { ProductID = 5, ProductName = "Mouse", MfgName = "Intex", Price = 450 });
            pl.Add(new Product() { ProductID = 6, ProductName = "HardDisk", MfgName = "Seggate", Price = 4500 });
            pl.Add(new Product() { ProductID = 7, ProductName = "KeyBoard", MfgName = "Dell", Price = 1250 });
            pl.Add(new Product() { ProductID = 8, ProductName = "Scanner", MfgName = "HUL", Price = 4300 });

            //var v = from m in pl where m.MfgName == "HUL" select m;

            //var v = from m in pl where m.MfgName == "Dell" && m.Price > 100 select m;

            //var v = from m in pl where m.ProductName.StartsWith("Mo") select m;

            var v = from m in pl where m.ProductName.Length < 5 select m;
            foreach(var temp in v)
            {
                temp.DispProduct();
            }
        }
    }
}
