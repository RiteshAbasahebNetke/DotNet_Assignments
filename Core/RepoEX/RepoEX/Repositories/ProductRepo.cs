using RepoEX.Models;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace RepoEX.Repositories
{
    public class ProductRepo:IProductRepo
    {
        List<Product> plst;

        public ProductRepo()
        {
            plst = new List<Product>();
            plst.Add(new Product() { ProductID = 1, ProductName = "Mouse", MfgName = "Intex", Price = 460 });
            plst.Add(new Product() { ProductID = 2, ProductName = "HardDsik", MfgName = "Seggate", Price = 4500 });
            plst.Add(new Product() { ProductID = 3, ProductName="Monitor", MfgName="LG",Price=35000 });
            plst.Add(new Product() { ProductID = 4, ProductName = "Charger", MfgName = "Mi", Price = 2300 });
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
