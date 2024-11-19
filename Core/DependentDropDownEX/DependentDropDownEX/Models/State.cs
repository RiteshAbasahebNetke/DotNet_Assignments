using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DependentDropDownEX.Models
{
    [Table("StateTbl")]
    public class State
    {
        [Key]
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        [ForeignKey("Country")]
        public Int64 CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}
