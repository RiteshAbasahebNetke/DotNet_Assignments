using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Repo_Test.Models
{
    [Table("FacilitiesTbl")]
    public class FlightFacilities
    {
        [Key]
       public Int64 FlightFeatureID {  get; set; }

        [ForeignKey("Flights")]
        public Int64 FlightID { get; set; }
        public virtual Flights Flights { get; set; }

        [ForeignKey("Facilities")]
        public Int64 FacilityID { get; set; }
        public virtual Facility Facilities { get; set; }
    }
}
