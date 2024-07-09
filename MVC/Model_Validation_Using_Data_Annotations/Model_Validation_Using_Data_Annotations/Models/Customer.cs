using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model_Validation_Using_Data_Annotations.Models
{
    public class Customer
    {
        public Int64 CustomerId { get; set; }

        [Required(ErrorMessage ="Customer name is mandatory")]
        public string CustomerName { get; set; }

        [EmailAddress(ErrorMessage ="Enter correct emailId")]
        public string EmailId { get; set; }

        [Required(ErrorMessage ="Mobile number is must")]
        [RegularExpression(@"^\d{10}$")]
        public string MobileNo { get; set; }

        [Range (1000,10000)]
        public decimal CreditLimit { get; set; }

        [Required(ErrorMessage ="Password is mandatory")]
     //   [RegularExpression(@"^\d{2}$")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please enter same password as mentioned above")]
        [Compare("Password",ErrorMessage ="Please enter same password as mentioned above")]
        public string ConfirmPassword { get; set; }
    }
}