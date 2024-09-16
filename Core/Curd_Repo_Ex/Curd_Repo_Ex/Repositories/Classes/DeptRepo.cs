using Curd_Repo_Ex.Models;
using Curd_Repo_Ex.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Curd_Repo_Ex.Repositories.Classes
{
    public class DeptRepo : IDeptRepo
    {
        ComapanyContext cc;
        public DeptRepo(ComapanyContext cc)
        {
            this.cc = cc;
        }
        public List<Dept> GetAllDepts()
        {
            return this.cc.Depts.ToList();
        }
    }
}
