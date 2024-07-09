using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EValidation_Model_Scaffholding_Template.Models
{
    [MetadataType(typeof(EmpTbl))]

  //  public partial class EmpTbl { }
    public class EmpVal
    {
        [Required(ErrorMessage ="EmpId is Mandatory")]
        public long EmpId { get; set; }
        [Required(ErrorMessage ="EmpName is Mandatory")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "EmailId is Mandatory")]
        [EmailAddress(ErrorMessage = "EmailId should be valid")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Salary is Mandatory")]
        [Range(15000,50000)]
        public string Salary { get; set; }
        [Required(ErrorMessage = "DepId is Mandatory")]
        public long DeptId { get; set; }
    }
}