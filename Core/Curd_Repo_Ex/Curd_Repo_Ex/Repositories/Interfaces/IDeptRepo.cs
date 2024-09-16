using Curd_Repo_Ex.Models;
using System.Collections.Generic;

namespace Curd_Repo_Ex.Repositories.Interfaces
{
    public interface IDeptRepo
    {
        List<Dept> GetAllDepts();
    }
}
