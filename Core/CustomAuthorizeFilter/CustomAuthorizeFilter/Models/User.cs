using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomAuthorizeFilter.Models
{
    public class User
    {
        public Int64 UserID { get; set; }
        [Required(ErrorMessage ="FirstName is mandatory")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        [Required(ErrorMessage = "Email is mandatory")]
        [EmailAddress]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="MobileNo is mandatory")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
