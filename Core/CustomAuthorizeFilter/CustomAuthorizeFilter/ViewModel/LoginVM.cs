using System.ComponentModel.DataAnnotations;

namespace CustomAuthorizeFilter.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="EmailID is mandatory")]
        [EmailAddress]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Password is mandatory")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
