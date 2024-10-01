namespace PartialViewEx.Models
{
    public class Emp
    {
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string EmailId { get; set; }
        public decimal Salary { get; set; }

        public Emp()
        {
            this.EmpID = 1;
            this.EmpName = "Sujit";
            this.DeptName = "Sales";
            this.EmailId = "sujit@hotmail.com";
            this.Salary = 45000;
        }
    }
}
