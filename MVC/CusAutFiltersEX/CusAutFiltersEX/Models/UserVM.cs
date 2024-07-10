using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CusAutFiltersEX.Models
{
    public class UserVM
    {
        [Required(ErrorMessage ="Please enter FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please enter LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter Address")]
        public string Address { get; set; }
        [Required(ErrorMessage =("Please enter correct EmailID"))]
        [EmailAddress]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Please enter correct MobileNo")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Please enter correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}