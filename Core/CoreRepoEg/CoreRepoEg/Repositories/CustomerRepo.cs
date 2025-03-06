using CoreRepoEg.Models;

namespace CoreRepoEg.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        CompanyContext cc;
        public CustomerRepo(CompanyContext cc)
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
            var rec=this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return this.cc.Customers.ToList();
        }

        public Customer GetByID(long id)
        {
            return this.cc.Customers.Find(id);
        }

        public void Update(Customer rec)
        {
            this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }
    }
}
