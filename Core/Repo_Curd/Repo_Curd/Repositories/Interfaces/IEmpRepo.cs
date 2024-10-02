using Repo_Curd.Models;
using System;
using System.Collections.Generic;

namespace Repo_Curd.Repositories.Interfaces
{
    public interface IEmpRepo
    {
        List<Emp> GetAll();
        List<Emp> GetByDeptID(Int64 id);
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(Int64 id);
        Emp GetByID(Int64 id);
    }
}
