using CurdOpUsing8VersionEx.Models;

namespace CurdOpUsing8VersionEx.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        Context c;
        public CategoryRepo(Context c)
        {
            this.c = c;
        }
        public List<Category> GetAll()
        {
            return this.c.Categories.ToList();
        }
    }
}
