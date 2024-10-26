using curdcoreEx.Models;

namespace curdcoreEx.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetAll();
        void Add(Product rec);
        void Edit(Product rec);
        void Delete(Int64 id);
        Product GetByID(Int64 id);
        List<Product> GetProducts(Int64 id);
    }
}
