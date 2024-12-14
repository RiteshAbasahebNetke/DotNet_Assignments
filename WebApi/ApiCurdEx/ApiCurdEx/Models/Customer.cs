using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCurdEx.Models
{
    [Table("CustomerTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
