using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class Customer
    {
        public Int64 CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public decimal CreditLimit { get; set; }
    }
}