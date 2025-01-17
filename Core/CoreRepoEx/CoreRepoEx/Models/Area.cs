using System.ComponentModel.DataAnnotations;

namespace CoreRepoEx.Models
{
    public class Area
    {
        public Int64 AreaID {  get; set; }
        [Required(ErrorMessage ="Please select area")]
        public string AreaName { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
