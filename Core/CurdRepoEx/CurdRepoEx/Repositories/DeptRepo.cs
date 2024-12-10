using CurdRepoEx.Models;

namespace CurdRepoEx.Repositories
{
    public class DeptRepo : IDeptRepo
    {
        CompanyContext cc;
        public DeptRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public List<Dept> GetAll()
        {
            return this.cc.Depts.ToList();
        }
    }
}
