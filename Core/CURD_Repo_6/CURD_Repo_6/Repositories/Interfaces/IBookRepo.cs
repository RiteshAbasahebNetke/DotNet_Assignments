using CURD_Repo_6.Models;
using Microsoft.EntityFrameworkCore;

namespace CURD_Repo_6.Repositories.Interfaces
{
    public interface IBookRepo
    {
        List<Book> GetAll();
        void Add(Book rec);
        void Edit(Book rec);
        void Delete(Int64 id);
        Book GetByID(Int64 id);
        List<Book> GetAllSub(Int64 id);
    }
}
