using curdEX.Models;

namespace curdEX.Repositiories
{
    public class DeptRepo : IDeptRepo
    {
        CompanyContext cc;
        public DeptRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public List<Dept> GetAllDept()
        {
            return this.cc.Depts.ToList();
        }
    }
}
