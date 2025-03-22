using CustCurdEX.Models;

namespace CustCurdEX.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        Context c;
        public CustomerRepo(Context c)
        {
            this.c = c;
        }
        public void Add(Customer rec)
        {
            this.c.Customers.Add(rec);
            this.c.SaveChanges();
        }

        public void Delete(Int64 id)
        {
            var rec=this.c.Customers.Find(id);
            this.c.Customers.Remove(rec);
            this.c.SaveChanges();
        }

        public void Edit(Customer rec)
        {
            this.c.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.c.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return this.c.Customers.ToList();
        }

        public Customer GetByID(long id)
        {
            return this.c.Customers.Find(id);
        }

        public List<Customer> GetCustomersByAID(long id)
        {
            var res=this.c.Customers.Where(p=>p.AreaID==id);
            return res.ToList();
        }
    }
}
