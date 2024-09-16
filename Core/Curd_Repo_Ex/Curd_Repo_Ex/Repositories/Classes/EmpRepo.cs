using Curd_Repo_Ex.Models;
using Curd_Repo_Ex.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Curd_Repo_Ex.Repositories.Classes
{
    public class EmpRepo : IEmpRepo
    {
        ComapanyContext cc;
        public EmpRepo(ComapanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Emp rec)
        {
            this.cc.Emps.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.cc.Emps.Find(id);
            this.cc.Emps.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Emp rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Emp> GetAll()
        {
            return this.cc.Emps.ToList();
        }

        public Emp GetByID(long id)
        {
            return this.cc.Emps.Find(id);
        }
    }
}
