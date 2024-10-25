using curdEX.Models;

namespace curdEX.Repositiories
{
    public interface IEmpRepo
    {
        List<Emp> GetAll();
        Emp GetById(Int64 id);
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(Int64 id);
        List<Emp> GetDepartment(Int64 id);
    }
}
