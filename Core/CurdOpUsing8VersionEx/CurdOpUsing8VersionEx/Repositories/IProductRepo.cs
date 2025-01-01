using CurdOpUsing8VersionEx.Models;

namespace CurdOpUsing8VersionEx.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetAll();
        void Add(Product rec);
        void Edit(Product rec);
        void Delete(Int64 id);
        Product GetProductByID(Int64 id);
    }
}
