using CurdOpUsing8VersionEx.Models;

namespace CurdOpUsing8VersionEx.Repositories
{
    public class ProductRepo : IProductRepo
    {
        Context c;
        public ProductRepo(Context c)
        {
            this.c = c;
        }

        public void Add(Product rec)
        {
            this.c.Products.Add(rec);
            this.c.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.c.Products.Find(id);
            this.c.Products.Remove(rec);
            this.c.SaveChanges();
        }

        public void Edit(Product rec)
        {
            this.c.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.c.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return this.c.Products.ToList();
        }

        public Product GetProductByID(long id)
        {
            return this.c.Products.Find(id);
        }
    }
}
