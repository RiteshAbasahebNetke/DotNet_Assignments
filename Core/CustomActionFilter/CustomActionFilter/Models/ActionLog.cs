using System.ComponentModel.DataAnnotations;

namespace CustomActionFilter.Models
{
    public class ActionLog
    {
        [Key]
        public Int64 ActionID { get; set; }
        public DateTime LogDateTime { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
    }
}
