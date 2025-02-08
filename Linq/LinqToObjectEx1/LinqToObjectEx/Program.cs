using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectEx
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public double Price { get; set; }

        public void DispProduct()
        {
            Console.WriteLine("ProductID is:" + ProductID);
            Console.WriteLine("Product Name:" + ProductName);
            Console.WriteLine("Mfg Name:" + MfgName);
            Console.WriteLine("Price:" + Price);
            Console.WriteLine();
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Product> pl=new List<Product>();
                pl.Add(new Product() { ProductID = 1, ProductName = "Mouse", MfgName ="Intex",Price=500});
                pl.Add(new Product() { ProductID = 2, ProductName = "Monitor", MfgName = "Dell", Price = 9800 });
                pl.Add(new Product() { ProductID = 3, ProductName = "Charger", MfgName = "Mi", Price = 890 });
                pl.Add(new Product() { ProductID = 4, ProductName = "Pendrive", MfgName = "HP", Price = 456 });
                pl.Add(new Product() { ProductID = 5, ProductName = "Scanner", MfgName = "HP", Price = 4569 });
                pl.Add(new Product() { ProductID = 6, ProductName = "Keyboard", MfgName = "Logitech", Price = 1230 });
                pl.Add(new Product() { ProductID = 7, ProductName = "Mobile", MfgName = "Samsung", Price = 12340 });

                //var v = from m in pl select m;

                //var v = from m in pl where m.ProductName=="Mouse" select m;

                //var v = from m in pl where m.ProductName == "Charger" && m.Price > 500 select m;

                //var v = from m in pl orderby m.Price descending select m;

                //var v = from m in pl orderby m.ProductName select m;

                //var v = from m in pl where m.ProductName.StartsWith("Mo") select m;

                //var v = from m in pl where m.Price > 8500 select m;

                //var v=from m in pl where m.ProductName.Length>7 select m;   

                var v = from m in pl orderby m.Price, m.MfgName select m;

                foreach (var temp in v)
                {
                    temp.DispProduct();
                }


                /*int[] n = { 12, 34, 56, 67, 64, 90, 31, 32, 89 };

                //var v = from m in n select m;

                var v=from m in n where m%2!=0 select m;

                foreach(var temp in v)
                {
                    Console.WriteLine(temp);
                }*/
            }
        }
    }
}
