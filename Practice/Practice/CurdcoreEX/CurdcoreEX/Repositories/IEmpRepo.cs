using CurdcoreEX.Models;

namespace CurdcoreEX.Repositories
{
    public interface IEmpRepo
    {
        List<Emp> GetAll();
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(Int64 id);
        Emp GetById(Int64 id);
        List<Emp> GetAllEmp(Int64 id);
    }
}
