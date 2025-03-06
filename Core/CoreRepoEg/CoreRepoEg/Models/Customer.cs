using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRepoEg.Models
{
    public class Customer
    {
        public Int64 CustomerID {  get; set; }
        public string CustomerName { get; set; }
        public string EmailID {  get; set; }
        public string MobileNo {  get; set; }
        public decimal CreditLimit {  get; set; }

        [ForeignKey("Area")]
        public Int64 AreaID {  get; set; }
        public virtual Area Area { get; set; }
    }
}
