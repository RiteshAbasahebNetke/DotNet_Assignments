using RepoCURD.Models;
using System;
using System.Collections.Generic;

namespace RepoCURD.Repositories.Interfaces
{
    public interface IDeptRepo
    {
        List<Department> GetAllDept();
    }
}
