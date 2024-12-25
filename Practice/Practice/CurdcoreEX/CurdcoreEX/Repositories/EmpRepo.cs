using CurdcoreEX.Models;

namespace CurdcoreEX.Repositories
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
            var rec=this.cc.Emps.Find(id);
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

        public List<Emp> GetAllEmp(long id)
        {
            var v = this.cc.Emps.Where(p => p.EmpID == id);
            return v.ToList();
        }

        public Emp GetById(long id)
        {
            return this.cc.Emps.Find(id);
        }
    }
}
