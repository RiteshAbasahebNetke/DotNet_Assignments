using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Model_Validation_Using_Data_Annotations.Models
{
    public class EvenVal:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var val = Convert.ToDecimal(value);
            if (val % 2 == 0)
                return true;
            else
                return false;
        }
    }
}