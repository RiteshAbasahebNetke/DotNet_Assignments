using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCurdEg.Models
{
    [Table("CustTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public decimal CreditLimit { get; set; }

        [ForeignKey("Area")]
        public Int64 AreaID {  get; set; }
        public virtual Area Area { get; set; }
    }
}
