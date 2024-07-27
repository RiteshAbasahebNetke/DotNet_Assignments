using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("UserTbl")]
    public class User
    {
        public Int64 UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        [ForeignKey("Country")]
        public Int64 CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}
