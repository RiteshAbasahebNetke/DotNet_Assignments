using CurdcoreEX.Models;

namespace CurdcoreEX.Repositories
{
    public class DeptRepo : IDeptRepo
    {
        CompanyContext cc;
        public DeptRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public List<Dept> GetDept()
        {
            return this.cc.Depts.ToList();
        }
    }
}
