namespace CoreRepoEg.Models
{
    public class Area
    {
        public Int64 AreaID {  get; set; }
        public string AreaName { get; set; }
        public virtual List<Customer> Customer { get; set; }
    }
}
