using CURDUsing6._0.Models;
using CURDUsing6._0.Repositories.Interfaces;
using System.Diagnostics;

namespace CURDUsing6._0.Repositories.Classes
{
    public class EmpRepo : IEmpRepo
    {
        CompanyContext cc;
        public EmpRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(Emp rec)
        {
            this.cc.Add(rec);
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

        public List<Emp> GetDepartment(long id)
        {
            var v = from m in this.cc.Emps
                    where m.DeptID == id
                    select m;

            return v.ToList();
        }
    }
}
