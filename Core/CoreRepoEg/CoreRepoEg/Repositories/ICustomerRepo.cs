using CoreRepoEg.Models;

namespace CoreRepoEg.Repositories
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        void Add(Customer rec);
        void Update(Customer rec);
        void Delete(Int64 id);
        Customer GetByID(Int64 id);
    }
}
