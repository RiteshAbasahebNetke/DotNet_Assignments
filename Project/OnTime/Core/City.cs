using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class City
    {
        public Int64 CityID { get; set; }
        public string CityName { get; set; }
        [ForeignKey("States")]
        public Int64 StateID { get; set; }
        public virtual List<State> States { get; set; }
    }
}
