using Core_Repo_Test.Models;
using Core_Repo_Test.Repositories.Interfaces;

namespace Core_Repo_Test.Repositories.Classes
{
    public class FlightsRepo : IFlightRepo
    {
        FlightContext fc;
        public FlightsRepo(FlightContext fc)
        {
            this.fc = fc;
        }
        public void Add(Flights rec)
        {
            this.fc.Add(rec);
            this.fc.SaveChanges();
        }

        public List<Flights> GetAll()
        {
            return this.fc.Flights.ToList();
        }
    }
}
