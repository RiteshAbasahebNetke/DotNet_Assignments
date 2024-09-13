using corecurdEx.Models;
using corecurdEx.Repositories.Interfaces;

namespace corecurdEx.Repositories.Classes
{
    public class AreaRepo : IAreaRepo
    {
        CustContext cc;
        public AreaRepo(CustContext cc)
        {
            this.cc = cc;
        }

        public List<Area> GetAreas()
        {
            return this.cc.Area.ToList();
        }
    }
}
