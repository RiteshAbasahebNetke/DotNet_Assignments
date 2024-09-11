using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Repo_Test.Models
{
    [Table("FlightsTbl")]
    public class Flights
    {
        [Key]
        public Int64 FlightID { get; set; }
        public string FlightNo { get; set;}
        public Int64 SourceCityID { get; set;}
        public Int64 DestinationCityID { get;set;}
        public decimal Fair {  get; set;}
        public Int64 TravelTime { get; set;}
        public bool IsDirect { get; set;}
        [ForeignKey("Cities")]
        public Int64 CityID { get; set;}
        public virtual List<City> City { get; set; }
        public virtual FlightFacilities FlightFacilities { get; set; }
    }
}
