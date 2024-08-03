using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class EditProfileVM
    {
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage =("EmailID Required"))]
        [EmailAddress(ErrorMessage =("Please enter valid Email ID"))]
        public string EmailID { get; set; }
        [Required]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 Digits Required")]
        public string MobileNo { get; set; }
    }
}
