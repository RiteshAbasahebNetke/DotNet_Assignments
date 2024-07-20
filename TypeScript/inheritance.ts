class Bill
{
    constructor(
       private billno:number,
       private billdate:string, 
       private customername:string
    ){}
    public DispBill():void
    {
        console.log("BillNo is:" + this.billno);
        console.log("Bill Date is:" + this.billdate);
        console.log("CustomerName is:" + this.customername);
    }
}

class MobileBill extends Bill
{
    constructor(
       billno:number,
       billdate:string,
       customername:string,
       private mobileno:string,
       private noofcalls:number,
       private callrate:number
    )
    {
        super(billno,billdate,customername);
    }
    public DispMobileBill():void
    {
        this.DispBill();
        console.log("MobileNo is:" + this.mobileno);
        console.log("NoOfCalls is:" + this.noofcalls);
        console.log("CallRate is:" + this.callrate);
        console.log("Amount:"+ this.noofcalls * this.callrate);
    }
}
let mb=new MobileBill(1,"22/10/2023","Suresh","765432190",100,2);
mb.DispMobileBill();