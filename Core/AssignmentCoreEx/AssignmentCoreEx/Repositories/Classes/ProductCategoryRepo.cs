using AssignmentCoreEx.Models;
using AssignmentCoreEx.Repositories.Interfaces;

namespace AssignmentCoreEx.Repositories.Classes
{
    public class ProductCategoryRepo:IProductCategoryRepo
    {
        Context c;
        public ProductCategoryRepo(Context c)
        {
            this.c = c;
        }

        public List<ProductCategory> GetAll()
        {
            return this.c.ProductCategories.ToList();
        }
    }
}
