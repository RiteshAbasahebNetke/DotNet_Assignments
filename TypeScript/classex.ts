class Emp
{
    private EmpId:number;
    private EmpName:string;
    private DeptName:string;
    private Salary:number;

    /*constructor()
    {
        this.EmpId=121;
        this.EmpName="Sunil";
        this.DeptName="Sales";;
        this.Salary=45670;
    } */

        constructor(eid:number,en:string,dn:string,s:number)
        {
           this.EmpId=eid;
           this.EmpName=en;
           this.DeptName=dn;
           this.Salary=s;
        }

    public AddEmp(eid:number,en:string,dn:string,s:number):void
    {
        this.EmpId=eid;
        this.EmpName=en;
        this.DeptName=dn;
        this.Salary=s;
    }
    public DispEmp():void
    {
        console.log("EmpID is:" + this.EmpId);
        console.log("EmpName is:" + this.EmpName);
        console.log("DeptName is:" + this.DeptName);
        console.log("Salary is:" + this.Salary);
    }
}
let e=new Emp(1,'Sam','Manufacturing',74630);
e.DispEmp();
e.AddEmp(123,"Suraj","Sales",87900);
e.DispEmp();
