using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class UserVM
    {
        [Required(ErrorMessage ="FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "EmailID Required")]
        [EmailAddress(ErrorMessage ="Please enter valid EmailID")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "MobileNo Required")]
        [RegularExpression(@"\d{9}", ErrorMessage = "9 Digits Required")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Int64 CountryID { get; set; }
        
    }
}
