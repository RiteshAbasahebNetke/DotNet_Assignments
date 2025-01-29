using AssignmentCoreEx.Models;
using AssignmentCoreEx.Repositories.Interfaces;

namespace AssignmentCoreEx.Repositories.Classes
{
    public class ColorRepo : IColorRepo
    {
        Context c;
        public ColorRepo(Context c)
        {
            this.c = c;
        }

        public List<Color> GetAll()
        {
            return this.c.Colors.ToList();
        }
    }
}
