using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Binding_EX.Models
{
    public class Customer
    {
        public Int64 CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public decimal CreditLimit { get; set; }
    }
}