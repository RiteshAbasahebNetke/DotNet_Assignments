using CoreCurdUsingDIEx.Models;

namespace CoreCurdUsingDIEx.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetAll();
        void Add(Product rec);
        void Edit(Product rec);
        void Delete(Int64 id);
        Product GetByID(Int64 id);
    }
}
