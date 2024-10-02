using Repo_Curd.Models;
using Repo_Curd.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repo_Curd.Repositories.Classes
{
    public class DeptRepo : IDeptRepo
    {
        EmpContext ec;
        public DeptRepo(EmpContext ec)
        {
            this.ec = ec;
        }
        public List<Department> GetAllDept()
        {
            return this.ec.Departments.ToList();
        }
    }
}
