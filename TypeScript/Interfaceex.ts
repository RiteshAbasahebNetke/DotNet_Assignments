interface IStudent
{
    RollNo:number;
    Name:string;
    EmailId:string;
    MobileNo:string;
}
function show(s:IStudent):void
{
    console.log("RollNo:" + s.RollNo);
    console.log("Name:"+ s.Name);
    console.log("EmailId:"+ s.EmailId);
    console.log("MobileNo:"+ s.MobileNo);
}
let s1:IStudent={RollNo:1,Name:'Sunil',EmailId:'sunil@hotmail.com',MobileNo:'736462662'};
show(s1);