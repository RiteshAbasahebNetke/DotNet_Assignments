using RepoEX.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepoEX.Repo
{
    public class ProductRepo : IProductRepo
    {
        List<Product> plst;
        public ProductRepo()
        {
            plst = new List<Product>();
            plst.Add(new Product() { ProductID = 1,ProductName="Mouse",MfgName="Dell",Price=560 });
            plst.Add(new Product() { ProductID = 2, ProductName = "Monitor", MfgName = "LG", Price = 9560 });
            plst.Add(new Product() { ProductID = 3, ProductName = "Keyboard", MfgName = "HP", Price = 1560 });
            plst.Add(new Product() { ProductID = 4, ProductName = "Charger", MfgName = "Mi", Price = 860 });
        }
        public List<Product> GetProducts()
        {
            return plst;
        }
        public void AddProducts(Product rec)
        {
            Int64 pid = plst.Max(p => p.ProductID);
            pid++;
            rec.ProductID = pid;
            plst.Add(rec);
        }
    }
}
