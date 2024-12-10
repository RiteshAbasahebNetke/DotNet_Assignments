using CurdRepoEx.Models;

namespace CurdRepoEx.Repositories
{
    public interface IEmpRepo
    {
        void Add(Emp rec);
        void Edit(Emp rec);
        List<Emp> GetAll();
        void Delete(Int64 id);
        Emp GetEmpByID(Int64 id);   
    }
}
