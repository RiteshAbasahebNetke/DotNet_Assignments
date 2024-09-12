using CoreCurd.Models;

namespace CoreCurd.Repositories.Interfaces
{
    public interface IBusRepo
    {
        List<Bus> GetAll();
        void Add(Bus rec);
        void Edit(Bus rec);
        void Delete(Int64 id);
        Bus GetByID(Int64 id);
        
    }
}
