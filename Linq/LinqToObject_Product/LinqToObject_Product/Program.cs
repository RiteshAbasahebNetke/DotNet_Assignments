using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject_Product
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Mfgname { get; set; }
        public decimal Price { get; set; }

        public void DispProduct()
        {
            Console.WriteLine("PrpductId:" + ProductId);
            Console.WriteLine("ProductName:" + ProductName);
            Console.WriteLine("MfgName:" + Mfgname);
            Console.WriteLine("Price:" + Price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pr = new List<Product>();
            pr.Add(new Product() { ProductId = 1, ProductName = "Monitor", Mfgname = "Dell", Price = 12000 });
            pr.Add(new Product() { ProductId = 2, ProductName = "Printer", Mfgname = "HP", Price = 9000 });
            pr.Add(new Product() { ProductId = 3, ProductName = "Scanner", Mfgname = "Toshiba", Price = 50000 });
            pr.Add(new Product() { ProductId = 4, ProductName = "Motherboard", Mfgname = "Logitech", Price = 19000 });
            pr.Add(new Product() { ProductId = 5, ProductName = "Mouse", Mfgname = "HUL", Price = 1200 });
            pr.Add(new Product() { ProductId = 6, ProductName = "Pendrive", Mfgname = "Sandisk", Price = 1000 });
            pr.Add(new Product() { ProductId = 7, ProductName = "Charger", Mfgname = "MI", Price = 9000 });
            pr.Add(new Product() { ProductId = 8, ProductName = "Keyboard", Mfgname = "Benq", Price = 3000 });
            pr.Add(new Product() { ProductId = 9, ProductName = "HardDisk", Mfgname = "Logitech", Price = 15000 });
            pr.Add(new Product() { ProductId = 10, ProductName = "Display", Mfgname = "Samsung", Price = 2500 });

            //var v = from m in pr
            //        where m.Price > 5000
            //        select m;

            //var v = from m in pr
            //        where m.Mfgname == "HUL" && m.Price>1000
            //        select m;

            //var v = from m in pr
            //        orderby m.Price descending
            //        select m;

            //var v = from m in pr
            //        where m.ProductName.StartsWith("Mo")
            //        select m;

            //var v = from m in pr
            //        where m.ProductName.Length > 5
            //        select m;

            //foreach(var temp in v)
            //{
            //    temp.DispProduct();
            //}

            //var v = from m in pr
            //        select m;

            //foreach(var temp in v)
            //{
            //    Console.WriteLine("ProductName:" + temp.ProductName);
            //    Console.WriteLine("Price:" + temp.Price);
            //}

            var v = from m in pr
                    orderby m.Price,
                    m.Mfgname
                    select m;

            foreach(var temp in v)
            {
                temp.DispProduct();
            }
            
        }
    }
}
