using CoreRepoEx.Models;

namespace CoreRepoEx.Repositories
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

        public List<Customer> GetAll()
        {
            return this.cc.Customers.ToList();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Customers.Find(id);
            this.cc.Customers.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Customer rec)
        {
            var oldrec=this.cc.Customers.Find(rec.CustomerID);
            oldrec.CustomerID = rec.CustomerID;
            oldrec.CustomerName=rec.CustomerName;
            oldrec.EmailID=rec.EmailID;
            oldrec.MobileNo=rec.MobileNo;
            oldrec.AreaID=rec.AreaID;
            oldrec.CreditLimit = rec.CreditLimit;
            this.cc.SaveChanges();

            /*this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();*/
        }

        public Customer GetById(long id)
        {
            return this.cc.Customers.Find(id);
        }
    }
}
