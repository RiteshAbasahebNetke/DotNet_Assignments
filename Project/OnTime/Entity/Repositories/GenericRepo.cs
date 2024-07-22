using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        CompanyContext cc;
        public GenericRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public void Add(T rec)
        {
            this.cc.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec=this.cc.Set<T>().Find(id);
            this.cc.Set<T>().Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(T rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<T> GetAll()
        {
            return this.cc.Set<T>().ToList();
        }

        public T GetByID(long id)
        {
            return this.cc.Set<T>().Find(id);
        }
    }
}
