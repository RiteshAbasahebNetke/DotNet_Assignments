using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CusAusFilter.Models
{
    public class UserVM
    {
        [Required(ErrorMessage ="Please enter the first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please enter the last name")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter the address")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Please enter the correct emailId")]
        [EmailAddress]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Please enter the mobile no")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Please enter the correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}