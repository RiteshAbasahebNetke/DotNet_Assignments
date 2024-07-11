using System;
using System.Collections.Generic;

namespace MVC_EX.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>();
            lst.Add(new Product() { ProductID = 1, ProductName = "Mouse", MfgName = "Intex", Price = 230 });
            lst.Add(new Product() { ProductID = 12, ProductName = "Monitor", MfgName = "Samsung", Price = 23000 });
            lst.Add(new Product() { ProductID = 14, ProductName = "Keyboard", MfgName = "Dell", Price = 330 });
            lst.Add(new Product() { ProductID = 15, ProductName = "HardDisk", MfgName = "Lofitech", Price = 2300 });

            return lst;
        }
    }
}
