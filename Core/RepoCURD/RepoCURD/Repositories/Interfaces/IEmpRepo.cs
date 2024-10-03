using RepoCURD.Models;
using System;
using System.Collections.Generic;

namespace RepoCURD.Repositories.Interfaces
{
    public interface IEmpRepo
    {
        List<Emp> GetAll();
        Emp GetByID(Int64 id);
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(Int64 id);
        List<Emp> GetEmpByDeptID (Int64 deptID);
    }
}
