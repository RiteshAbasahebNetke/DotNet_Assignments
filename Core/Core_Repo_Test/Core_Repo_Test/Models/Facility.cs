using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Repo_Test.Models
{
    [Table("FacilityTbl")]
    public class Facility
    {
        [Key]
        public Int64 FacilityID { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDesc { get; set; }
        public virtual FlightFacilities FlightFacilities { get; set; }
    }
}
