using CoreRepoEx.Models;

namespace CoreRepoEx.Repositories
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        void Add(Customer rec);
        void Edit(Customer rec);
        void Delete(Int64 id);
        Customer GetById(Int64 id);
    }
}
