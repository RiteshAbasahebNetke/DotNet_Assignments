using CoreCurdUsingDIEx.Models;

namespace CoreCurdUsingDIEx.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        CompanyContext cc;
        public CategoryRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public List<Category> GetAll()
        {
            return this.cc.Categories.ToList();
        }
    }
}
