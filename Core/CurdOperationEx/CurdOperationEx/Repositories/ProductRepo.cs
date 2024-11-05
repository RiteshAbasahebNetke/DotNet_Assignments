using CurdOperationEx.Models;

namespace CurdOperationEx.Repositories
{
    public class ProductRepo : IProductRepo
    {
        CompanyContext cc;
        public ProductRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public void Add(Product rec)
        {
            this.cc.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Product rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public Product GetByID(long id)
        {
            return this.cc.Products.Find(id);
        }

        public List<Product> GetAll()
        {
            return this.cc.Products.ToList();
        }
    }
}
