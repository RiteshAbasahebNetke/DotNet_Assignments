using Repo_Curd.Models;
using Repo_Curd.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repo_Curd.Repositories.Classes
{
    public class EmpRepo : IEmpRepo
    {
        EmpContext ec;
        public EmpRepo(EmpContext ec)
        {
            this.ec = ec;
        }
        public void Add(Emp rec)
        {
            this.ec.Emps.Add(rec);
            this.ec.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.ec.Emps.Find(id);
            this.ec.Emps.Remove(rec);
            this.ec.SaveChanges();
        }

        public void Edit(Emp rec)
        {
            this.ec.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.ec.SaveChanges();
        }

        public List<Emp> GetAll()
        {
            return this.ec.Emps.ToList();
        }

        public List<Emp> GetByDeptID(long id)
        {
            return this.ec.Emps.ToList();
        }

        public Emp GetByID(long id)
        {
            return this.ec.Emps.Find(id);
        }
    }
}
