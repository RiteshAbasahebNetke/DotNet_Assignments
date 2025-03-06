using CoreRepoEg.Models;

namespace CoreRepoEg.Repositories
{
    public class AreaRepo : IAreaRepo
    {
        CompanyContext cc;
        public AreaRepo(CompanyContext cc)
        {
            this.cc = cc;
        }
        public List<Area> GetAll()
        {
            return this.cc.Areas.ToList();
        }
    }
}
