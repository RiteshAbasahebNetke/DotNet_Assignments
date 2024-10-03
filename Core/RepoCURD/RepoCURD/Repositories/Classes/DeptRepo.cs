using RepoCURD.Models;
using RepoCURD.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RepoCURD.Repositories.Classes
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
