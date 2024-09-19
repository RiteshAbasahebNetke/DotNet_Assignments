using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CusAusFilter.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Please enter the valid emailid")]
        [EmailAddress]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Please enter the correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}