using CustCurdEX.Models;

namespace CustCurdEX.Repositories
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll();
        void Add(Customer rec);
        void Edit(Customer rec);
        void Delete(Int64 id);
        Customer GetByID(Int64 id);
        List<Customer> GetCustomersByAID(Int64 id);
    }
}
