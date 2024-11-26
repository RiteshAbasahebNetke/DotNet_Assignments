using CureOp26EX.Models;

namespace CureOp26EX.Repositories
{
    public interface IEmpRepo
    {
        List<Emp> GetAll();
        void Add(Emp rec);
        void Edit(Emp rec);
        Emp GetById(Int64 id);
        void Delete(Int64 id);
        
    }
}
