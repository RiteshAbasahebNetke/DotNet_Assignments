using CureOp26EX.Models;

namespace CureOp26EX.Repositories
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
            this.cc.Emps.Add(rec);
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

        public Emp GetById(long id)
        {
            return this.cc.Emps.Find(id);
        }
    }
}
