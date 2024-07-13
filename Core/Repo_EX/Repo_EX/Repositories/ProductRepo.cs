using Repo_EX.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repo_EX.Repositories
{
    public class ProductRepo
    {
        static List<Product> plst;
        static ProductRepo()
        {
            plst = new List<Product>();
            plst.Add(new Product() { ProductID = 1, ProductName = "Mouse", MfgName = "Intex", Price = 1450 });
            plst.Add(new Product() { ProductID = 2, ProductName = "Monitor", MfgName = "LG", Price = 40050 });
            plst.Add(new Product() { ProductID = 3, ProductName = "Keyboard", MfgName = "Dell", Price = 2450 });
            plst.Add(new Product() { ProductID = 4, ProductName = "HardDisk", MfgName = "Seggate", Price = 4450 });
        }
        public List<Product> GetProducts()
        {
            return plst;
        }
        public void AddProduct(Product rec)
        {
            Int64 pid = plst.Max(p => p.ProductID);
            pid++;
            rec.ProductID = pid;
            plst.Add(rec);
        }
    }
}
