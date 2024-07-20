/* ------------------------- ADDITION
function sum(a:number,b:number):number
{
   return a+b;
}
var r:number=sum(10,20);
console.log("Sum is:"+ r);

-----------------------------SQUARE
var sq=function(a:number):void
{
    console.log("Sqaure is:" +(a*a));
}
sq(10);

-----------------------------CUBE
let cu=(a:number)=>a*a*a;
var r=cu(10);
console.log("Cube is:" + r);

function show(a:number,b:number,c:number):void
{
    console.log("Value of a:" + a);
    console.log("Value of b:" + b);
    console.log("Value of c:" + c);
}
show(354,5465,5);

function opval(a:number,b?:number):void
{
    console.log("Value of a:"+a);
    console.log("Value of b:"+ b);
}
opval(10);*/
function display() {
    var n = [];
    for (var _i = 0; _i < arguments.length; _i++) {
        n[_i] = arguments[_i];
    }
    n.forEach(function (val) {
        console.log(val);
    });
}
display(12, 23, 445, 566, 785, 323, 44);
