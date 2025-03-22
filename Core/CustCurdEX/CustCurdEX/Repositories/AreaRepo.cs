using CustCurdEX.Models;

namespace CustCurdEX.Repositories
{
    public class AreaRepo : IAreaRepo
    {
        Context c;
        public AreaRepo(Context c)
        {
            this.c = c;
        }
        public List<Area> GetAll()
        {
            return this.c.Areas.ToList();
        }
    }
}
