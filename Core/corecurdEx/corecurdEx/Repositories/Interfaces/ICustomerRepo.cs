using corecurdEx.Models;

namespace corecurdEx.Repositories.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        void Add(Customer rec);
        void Edit(Customer rec);
        void Delete(Int64 id);
        Customer GetById(Int64 id);
        List<Customer> GetByAreaID(Int64 id);
    }
}
