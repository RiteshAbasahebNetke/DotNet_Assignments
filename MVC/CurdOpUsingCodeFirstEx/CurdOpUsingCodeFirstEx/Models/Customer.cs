using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CurdOpUsingCodeFirstEx.Models
{
    [Table("CustomerTbl")]
    public class Customer
    {
        [Key]
        public Int64 CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmailID { get; set; }
        public decimal CreditLimit { get; set; }

        [ForeignKey("Area")]
        public Int64 AreaID { get; set; }
        public virtual Area Area { get; set; }
    }
}