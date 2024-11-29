using CurdUsingRepoEX.Models;

namespace CurdUsingRepoEX.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetAll();
        void Add(Product rec);
        void Edit(Product rec);
        void Delete(Int64 id);
        Product GetById(Int64 id);
    }
}
