using Curd_Repo_Ex.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;

namespace Curd_Repo_Ex.Repositories.Interfaces
{
    public interface IEmpRepo
    {
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(Int64 id);
        Emp GetByID(Int64 id);
        List<Emp> GetAll();
    }
}
