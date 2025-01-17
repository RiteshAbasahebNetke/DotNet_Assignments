using CoreRepoEx.Models;

namespace CoreRepoEx.Repositories
{
    public class AreaRepo : IAreaRepo
    {
        CustContext cc;
        public AreaRepo(CustContext cc)
        {
            this.cc = cc;
        }
        public List<Area> GetAll()
        {
            return this.cc.Areas.ToList();
        }
    }
}
