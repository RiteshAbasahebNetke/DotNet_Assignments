using System.ComponentModel.DataAnnotations;

namespace CustomAuthFilter.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        [Required(ErrorMessage ="Product name is mandatory")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="MfgName is mandatory")]
        public string MfgName { get; set; }
        [Required(ErrorMessage ="Price is mandatory")]
        [Range(400,10000)]
        public decimal Price { get; set; }
    }
}
