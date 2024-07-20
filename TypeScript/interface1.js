var Demo = /** @class */ (function () {
    function Demo() {
    }
    Demo.prototype.AMethod = function () {
        console.log('AMethod called...!');
    };
    Demo.prototype.A1Method = function () {
        console.log('A1Mthod Called....!');
    };
    Demo.prototype.B1Method = function () {
        console.log('B1Method Called...!');
    };
    return Demo;
}());
var d = new Demo();
d.AMethod();
d.A1Method();
d.B1Method();
