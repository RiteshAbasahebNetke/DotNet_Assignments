using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionToView.Models
{
    public class Products
    {
        public Int64 ProductId { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public static List<Products> GetProducts()
        {
            List<Products> pl = new List<Products>();
            pl.Add(new Products() { ProductId = 1, ProductName = "Monitor", MfgName = "LG", Price = 20000 });
            pl.Add(new Products() { ProductId = 11, ProductName = "Printer", MfgName = "HP", Price = 8000 });
            pl.Add(new Products() { ProductId = 21, ProductName = "Keyboard", MfgName = "Dell", Price = 2000 });
            pl.Add(new Products() { ProductId = 31, ProductName = "Mouse", MfgName = "Intex", Price = 200 });
            pl.Add(new Products() { ProductId = 41, ProductName = "Motherboard", MfgName = "HUL", Price = 22000 });

            return pl;
        }
    }
}