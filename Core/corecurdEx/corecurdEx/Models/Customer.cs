using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace corecurdEx.Models
{
    [Table("CustomerTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID { get; set; }
        [Required(ErrorMessage ="Customer Name is mandatory")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="EmailId is mandatory")]
        [EmailAddress(ErrorMessage ="EmailID is required")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Mobile no. should be 10 digit")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Please enter credit limit")]
        [Range(2000,49000)]
        public decimal CreditLimit { get; set; }
        [ForeignKey("Area")]
        public Int64 AreaID { get; set; }
        public virtual Area Area { get; set; }
    }
}
