class Emp
{
    empid:number;
    empname:string;
    deptname:string;
    salary:number;

    constructor(eid:number,en:string,dn:string,s:number)
    {
        this.empid=eid;
        this.empname=en;
        this.deptname=dn;
        this.salary=s;
    }
    public AddEmp(empid:number,empname:string,deptname:string,salary:number):void
    {
        this.empid;
        this.empname;
        this.deptname;
        this.salary;
    }
    public disp():void
    {
        console.log("EmpID:" + this.empid);
        console.log("EmpName:"+ this.empname);
        console.log("DeptName:" + this.deptname);
        console.log("Salary:"+ this.salary);
    }
}
let e=new Emp(1,'Sunil','Sales',89790);
e.disp();