using CURD_Repo_6.Models;
using CURD_Repo_6.Repositories.Interfaces;

namespace CURD_Repo_6.Repositories.Classes
{
    public class BookRepo : IBookRepo
    {
        Context c;
        public BookRepo(Context c)
        {
            this.c = c;
        }
        public void Add(Book rec)
        {
            this.c.Books.Add(rec);
            this.c.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec = this.c.Books.Find(id);
            this.c.Books.Remove(rec);
            this.c.SaveChanges();
        }

        public void Edit(Book rec)
        {
            this.c.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.c.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return this.c.Books.ToList();
        }

        public List<Book> GetAllSub(long id)
        {
            var v = this.c.Books.Where(p => p.SubjectID == id);
            return v.ToList();
        }

        public Book GetByID(long id)
        {
            return this.c.Books.Find(id);
        }
    }
}
