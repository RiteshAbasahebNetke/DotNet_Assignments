using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCurd.Models
{
    [Table("BusTbl")]
    public class Bus
    {
        [Key]
        public Int64 BusID { get; set; }
        [Required(ErrorMessage ="Please enter the busname")]
        public string BusName { get; set; }
        [Required(ErrorMessage =("Please enter busno"))]
        public string BusNo { get; set; }
        [Required(ErrorMessage =("Please enter the price"))]
        public decimal Fare { get; set; }
        [ForeignKey("City")]
        public Int64 CityID { get; set; }
        public virtual City City { get; set; }
    }
}
