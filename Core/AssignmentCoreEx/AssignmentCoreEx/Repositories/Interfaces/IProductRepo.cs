using AssignmentCoreEx.Models;

namespace AssignmentCoreEx.Repositories.Interfaces
{
    public interface IProductRepo
    {
        List<Product> GetAll();
        void Add(Product rec);
    }
}
