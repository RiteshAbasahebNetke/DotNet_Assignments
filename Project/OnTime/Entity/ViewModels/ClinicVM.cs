using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class ClinicVM
    {
        [Required]
        public string ClinicName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"\d{9}",ErrorMessage ="9 Digits Required")]
        public string MobileNo { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string EmailID { get; set; }
        [Required]
        public string ContactPersonName { get; set; }
        [Required]
        [RegularExpression(@"\d{6}",ErrorMessage ="6 Digits Required")]
        public string LandLineNo { get; set; }
        [Required]
        public string WebsiteUrl { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public Int64 CityID { get; set; }
    }
}
