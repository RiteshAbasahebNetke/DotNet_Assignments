using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class PatientVM
    {
        public Int64 PatientID { get; set; }
        [Required(ErrorMessage ="FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "MobileNo Required")]
        [RegularExpression(@"\d{9}", ErrorMessage = "9 Digits Required")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Enter Patient Gender")]
        public string Gender { get; set; }
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public IFormFile PatientPhoto { get; set; }
        public string PhotoPath { get; set; }
        public Int64 UserID { get; set; }
        public string UserName { get; set; }
    }
}
