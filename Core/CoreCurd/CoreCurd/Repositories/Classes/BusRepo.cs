using CoreCurd.Models;
using CoreCurd.Repositories.Interfaces;

namespace CoreCurd.Repositories.Classes
{
    public class BusRepo : IBusRepo
    {
        Context cc;
        public BusRepo(Context cc)
        {
            this.cc = cc;
        }

        public void Add(Bus rec)
        {
            this.cc.Buses.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec=this.cc.Buses.Find(id);
            this.cc.Buses.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Bus rec)
        {
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }

        public List<Bus> GetAll()
        {
            return this.cc.Buses.ToList();
        }

        public Bus GetByID(long id)
        {
            return this.cc.Buses.Find(id);
        }
    }
}
