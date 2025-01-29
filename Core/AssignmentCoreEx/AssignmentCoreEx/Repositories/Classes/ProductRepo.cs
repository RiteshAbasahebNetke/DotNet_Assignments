using AssignmentCoreEx.Models;
using AssignmentCoreEx.Repositories.Interfaces;

namespace AssignmentCoreEx.Repositories.Classes
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

        public List<Product> GetAll()
        {
            return this.c.Products.ToList();
        }
    }
}
