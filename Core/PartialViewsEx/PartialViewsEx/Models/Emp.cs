namespace PartialViewsEx.Models
{
    public class Emp
    {
        public Int64 EmpID { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public decimal Salary { get; set; }

        public Emp()
        {
            this.EmpID = 1;
            this.EmpName = "Rajesh";
            this.DeptName = "Computer";
            this.EmailID = "rajesh@hotmail.com";
            this.MobileNo = "893323321";
            this.Salary = 69000;
        }
    }
}
