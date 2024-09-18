using CURDUsing6._0.Models;
using CURDUsing6._0.Repositories.Interfaces;

namespace CURDUsing6._0.Repositories.Classes
{
    public class DeptRepo : IDeptRepo
    {
        CompanyContext cc;
        public DeptRepo(CompanyContext cc) 
        {
            this.cc = cc;
        }
        public List<Dept> GetAllDepts()
        {
            return this.cc.Depts.ToList();
        }
    }
}
