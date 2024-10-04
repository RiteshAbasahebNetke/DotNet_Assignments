using RepoEX.Models;
using System.Collections.Generic;

namespace RepoEX.Repo
{
    public interface IProductRepo
    {
        List<Product> GetProducts();
        void AddProducts(Product rec);
    }
}
