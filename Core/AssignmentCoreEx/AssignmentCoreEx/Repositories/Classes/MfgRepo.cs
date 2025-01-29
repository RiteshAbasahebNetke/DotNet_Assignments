using AssignmentCoreEx.Models;
using AssignmentCoreEx.Repositories.Interfaces;

namespace AssignmentCoreEx.Repositories.Classes
{
    public class MfgRepo : IMfgRepo
    {
        Context c;
        public MfgRepo(Context c)
        {
            this.c = c;
        }

        public List<Mfg> GetAll()
        {
            return this.c.Mfgs.ToList();
        }
    }
}
