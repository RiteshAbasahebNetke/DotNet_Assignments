using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomAuthFilter.Models
{
    public class User
    {
        public Int64 UserID { get; set; }
        [Required(ErrorMessage = "First name is mandatory")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is mandatory")]
        public string LastName { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        [Required(ErrorMessage = "MobileNo is mandatory and it should be 10 digit")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "EmailID is mandatory")]
        [EmailAddress(ErrorMessage ="EmailID is mandatory")]
        public string EmailID { get; set; }
        [Required(ErrorMessage = "Please enter correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
