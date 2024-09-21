using CustomAuthFilter.Models;
using CustomAuthFilter.Repositories.Interfaces;

namespace CustomAuthFilter.Repositories.Classes
{
    public class ProductRepo:IProductRepo
    {
        Context cc;
        public ProductRepo(Context cc)
        {
            this.cc = cc;
        }
        public List<Product> GetAll()
        {
            return this.cc.Products.ToList();
        }
    }
}
