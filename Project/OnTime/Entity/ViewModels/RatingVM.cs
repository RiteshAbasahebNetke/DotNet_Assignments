using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class RatingVM
    {
        public string FirstName { get; set; }
        public Int64 DoctorRatingID { get; set; }
        public int Rating { get; set; }
        public string Remark { get; set; }
    }
}
