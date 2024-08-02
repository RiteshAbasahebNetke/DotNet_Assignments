using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class DocSpecilityVM
    {
        public Int64 DoctorSpecilityID { get; set; }
        public Int64 DoctorID { get; set; }
        [Required(ErrorMessage ="FirstName Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "MobileNo Required")]
        [RegularExpression(@"\d{9}", ErrorMessage = "9 Digits Required")]
        public string MobileNo { get; set; }
        public bool IsAvailable { get; set; }
        [Required(ErrorMessage = "Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "DoctorExperience Required")]
        public string DoctorExperience { get; set; }
        public IFormFile DoctorPhoto { get; set; }
        public string PhotoPath { get; set; }
        [Required(ErrorMessage = "DoctorQualification Required")]
        public string DoctorQualification { get; set; }
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Int64 SpecilityID { get; set; }
        public Int64 AreaID { get; set; }
        public string AreaName { get; set; }
        public List<Int64> Specilities { get; set; }
        public List<string> SpecilityString { get; set; }
    }
}
