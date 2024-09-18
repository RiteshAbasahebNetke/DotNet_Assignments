using CURDUsing6._0.Models;

namespace CURDUsing6._0.Repositories.Interfaces
{
    public interface IEmpRepo
    {
        List<Emp> GetAll();
        Emp GetByID(Int64 id);
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(Int64 id);
        List<Emp> GetDepartment(Int64 id);
    }
}
