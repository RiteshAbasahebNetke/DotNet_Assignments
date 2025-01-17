using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRepoEx.Models
{
    public class Customer
    {
        public Int64 CustomerID {  get; set; }
        [Required(ErrorMessage ="Please enter the valid Customer Name")]
        public string CustomerName {  get; set; }
        [Required(ErrorMessage ="Please enter a valid emailid")]
        [EmailAddress(ErrorMessage ="Incorrect EmailID")]
        public string EmailID {  get; set; }
        [Required(ErrorMessage ="Please enter 9 digit mobile number")]
        public string MobileNo {  get; set; }
        [Required(ErrorMessage ="Please enter a credit limit")]
        [Range(10000,3000)]
        public decimal CreditLimit { get; set; }

        [ForeignKey("Area")]
        public Int64 AreaID {  get; set; }
        public virtual Area Area { get; set; }
    }
}
