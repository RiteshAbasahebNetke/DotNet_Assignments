interface AInt
{
    AMethod():void;
    A1Method():void;
}
interface BInt
{
    B1Method():void;
}

class Demo implements AInt,BInt
{
    AMethod():void
    {
        console.log('AMethod called...!');
    }
    A1Method():void
    {
         console.log('A1Mthod Called....!');
    }
    B1Method():void
    {
        console.log('B1Method Called...!');
    }
}
let d=new Demo();
d.AMethod();
d.A1Method();
d.B1Method();