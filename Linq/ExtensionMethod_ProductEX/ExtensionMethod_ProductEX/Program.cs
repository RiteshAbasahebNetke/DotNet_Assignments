using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod_ProductEX
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public void DispProduct()
        {
            Console.WriteLine("ProductId:" + ProductId);
            Console.WriteLine("ProductName:" + ProductName);
            Console.WriteLine("MfgName:" + MfgName);
            Console.WriteLine("Price:" + Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pl = new List<Product>();
            pl.Add(new Product() { ProductId = 1, ProductName = "Monitor", MfgName = "Samsung", Price = 19000 });
            pl.Add(new Product() { ProductId = 2, ProductName = "Printer", MfgName = "HP", Price = 8500 });
            pl.Add(new Product() { ProductId = 3, ProductName = "Scanner", MfgName = "Dell", Price = 5200 });
            pl.Add(new Product() { ProductId = 4, ProductName = "KeyBoard", MfgName = "Benq", Price = 1900 });
            pl.Add(new Product() { ProductId = 5, ProductName = "MotherBoard", MfgName = "HUL", Price = 21000 });

            // var v = pl.OrderByDescending(p => p.Price).Skip(1).Take(1);
            // var v = pl.Skip(4);
            // var v = pl.Where(p => p.MfgName == "HUL").OrderByDescending(p => p.Price);

            var v = from m in pl
                    group m by m.MfgName into m
                    select new
                    {
                        Mname = m.Key,
                        MinPrice = m.Min(p => p.Price),
                        MaxPrice = m.Max(p => p.Price),
                        TotalProduct = m.Count()
                    };
                    

            foreach(var temp in v)
            {
                Console.WriteLine("MfgName:" + temp.Mname + "MinPrice:" + temp.MinPrice + "Maxprice:" + temp.MaxPrice + "TotalProduct:" + temp.TotalProduct);
            }
        }
    }
}
