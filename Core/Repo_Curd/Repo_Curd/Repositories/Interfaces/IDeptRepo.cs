using Repo_Curd.Models;
using System;
using System.Collections.Generic;

namespace Repo_Curd.Repositories.Interfaces
{
    public interface IDeptRepo
    {
        List<Department> GetAllDept();
    }
}
