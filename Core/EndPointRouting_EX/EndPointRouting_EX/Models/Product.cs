using System;
using System.Collections.Generic;

namespace EndPointRouting_EX.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetAllProducts()
        {
            List<Product> lst = new List<Product>();
            lst.Add(new Product() { ProductID = 1, ProductName = "Mouse", MfgName = "Dell", Price = 450 });
            lst.Add(new Product() { ProductID = 2, ProductName = "Monitor", MfgName = "Intex", Price = 1230 });
            lst.Add(new Product() { ProductID = 3, ProductName = "HardDisk", MfgName = "Logitech", Price = 4570 });
            lst.Add(new Product() { ProductID = 4, ProductName = "Charger", MfgName = "MI", Price = 670 });

            return lst;
        }
    }
}
