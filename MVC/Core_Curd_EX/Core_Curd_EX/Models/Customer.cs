using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Curd_EX.Models
{
    [Table("CustomerTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID { get; set; }
        [Required(ErrorMessage ="Please enter customer name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Please enter EmailID")]
        [EmailAddress(ErrorMessage ="Please enter valid EmailID")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Please enter credit limit")]
        [Range(1000,11111)]
        public decimal CreditLimit { get; set; }
        [ForeignKey("Area")]
        public Int64 AreaID { get; set; }
        public virtual Area Area { get; set; }
    }
}
