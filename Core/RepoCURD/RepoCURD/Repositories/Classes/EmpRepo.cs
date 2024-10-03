using RepoCURD.Models;
using RepoCURD.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepoCURD.Repositories.Classes
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


        public Emp GetByID(Int64 id)
        {
            return this.ec.Emps.Find(id);
        }

        public List<Emp> GetEmpByDeptID(long deptID)
        {
            var v = from m in this.ec.Emps
                    where m.DeptID == deptID
                    select m;

            return v.ToList();
        }
    }
}
