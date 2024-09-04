using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_BindingEX.Models
{
    public class Customer
    {
        public Int64 CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public decimal CreditLimit { get; set; }
    }
}