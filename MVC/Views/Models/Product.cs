using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Views.Models
{
    public class Product
    {
        public Int64 ProductId { get; set; }

        public string ProductName { get; set; }

        public string MfgName { get; set; }

        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> pl = new List<Product>();
            pl.Add(new Product() { ProductId = 1, ProductName = "Monitor", MfgName = "LG", Price = 15000 });
            pl.Add(new Product() { ProductId = 2, ProductName = "Mouse", MfgName = "Intex", Price = 500 });
            pl.Add(new Product() { ProductId = 3, ProductName = "Keyboard", MfgName = "Lava", Price = 2500 });
            pl.Add(new Product() { ProductId = 4, ProductName = "Charger", MfgName = "Mi", Price = 900 });
            pl.Add(new Product() { ProductId = 5, ProductName = "Motherboard", MfgName = "Segate", Price = 25000 });
            pl.Add(new Product() { ProductId = 6, ProductName = "Screen", MfgName = "Samsung", Price = 9500 });

            return pl;
        }
    }
}