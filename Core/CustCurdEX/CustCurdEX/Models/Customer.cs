using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustCurdEX.Models
{
    [Table("CustTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID {  get; set; }
        [Required(ErrorMessage ="Please enter valid Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Please enter valid Address")]
        public string Address {  get; set; }
        [EmailAddress(ErrorMessage ="Please enter valid email id")]
        public string EmailID {  get; set; }
        [Range(1000,10000)]
        public decimal CreditLimit {  get; set; }

        [ForeignKey("Area")]
        public Int64 AreaID {  get; set; }
        public virtual Area Area { get; set; }
    }
}
