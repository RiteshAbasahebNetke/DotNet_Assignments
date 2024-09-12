using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCurd.Models
{
    [Table("CityTbl")]
    public class City
    {
        [Key]
        public Int64 CityID { get; set; }
        [Required(ErrorMessage =("Please select the city"))]
        public string CityName { get; set; }
        public virtual List<Bus> Buses { get; set; }
    }
}
