using Core_Repo_Test.Models;

namespace Core_Repo_Test.Repositories.Interfaces
{
    public interface IFlightRepo
    {
        void Add(Flights rec);
        List<Flights> GetAll();
    }
}
