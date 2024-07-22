using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class LoginResultVM
    {
        public bool IsLoggedIn { get; set; }
        public Int64 LoggedInID { get; set; }
        public string LoggedInName { get; set; }
    }
}
