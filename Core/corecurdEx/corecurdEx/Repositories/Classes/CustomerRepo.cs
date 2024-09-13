using corecurdEx.Models;
using corecurdEx.Repositories.Interfaces;

namespace corecurdEx.Repositories.Classes
{
    public class CustomerRepo : ICustomerRepo
    {
        CustContext cc;
        public CustomerRepo(CustContext cc)
        {
            this.cc = cc;
        }

        public void Add(Customer rec)
        {
            this.cc.Customers.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Customer rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Customer> GetAll()
        {
           return this.cc.Customers.ToList();
        }

        public List<Customer> GetByAreaID(long id)
        {
            var v = from m in this.cc.Customers
                    where m.AreaID == id
                    select m;
            return v.ToList();
        }

        public Customer GetById(long id)
        {
            return this.cc.Customers.Find(id);
        }
    }
}
