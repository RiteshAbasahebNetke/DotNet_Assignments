var Emp = /** @class */ (function () {
    /*constructor()
    {
        this.EmpId=121;
        this.EmpName="Sunil";
        this.DeptName="Sales";;
        this.Salary=45670;
    } */
    function Emp(eid, en, dn, s) {
        this.EmpId = eid;
        this.EmpName = en;
        this.DeptName = dn;
        this.Salary = s;
    }
    Emp.prototype.AddEmp = function (eid, en, dn, s) {
        this.EmpId = eid;
        this.EmpName = en;
        this.DeptName = dn;
        this.Salary = s;
    };
    Emp.prototype.DispEmp = function () {
        console.log("EmpID is:" + this.EmpId);
        console.log("EmpName is:" + this.EmpName);
        console.log("DeptName is:" + this.DeptName);
        console.log("Salary is:" + this.Salary);
    };
    return Emp;
}());
var e = new Emp(1, 'Sam', 'Manufacturing', 74630);
e.DispEmp();
e.AddEmp(123, "Suraj", "Sales", 87900);
e.DispEmp();
