using RepoEX.Models;
using System.Collections.Generic;

namespace RepoEX.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetProducts();
        void AddProduct(Product rec);
    }
}
