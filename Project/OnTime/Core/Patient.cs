using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("PatientTbl")]
    public class Patient
    {
        [Key]
        public Int64 PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public string EmailID { get; set; }
        public string PhotoPath { get; set; }
        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }
    }
}
