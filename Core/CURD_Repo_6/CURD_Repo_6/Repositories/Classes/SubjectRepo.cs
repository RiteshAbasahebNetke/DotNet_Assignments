using CURD_Repo_6.Models;
using CURD_Repo_6.Repositories.Interfaces;

namespace CURD_Repo_6.Repositories.Classes
{
    public class SubjectRepo:ISubjectRepo
    {
        Context c;
        public SubjectRepo(Context c)
        {
            this.c = c;
        }

        public List<Subject> GetAllSubjects()
        {
            return this.c.Subjects.ToList();
        }
    }
}
