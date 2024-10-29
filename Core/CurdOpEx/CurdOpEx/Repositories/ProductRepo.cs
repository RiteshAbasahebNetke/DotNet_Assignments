using CurdOpEx.Models;

namespace CurdOpEx.Repositories
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
            var rec=this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Product rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return this.cc.Products.ToList();
        }

        public Product GetById(long id)
        {
            return this.cc.Products.Find(id);
        }

        public List<Product> GetProducts(long id)
        {
            var c = from m in this.cc.Products
                    where m.ProductID == id
                    select m;
            return c.ToList();
        }
    }
}
