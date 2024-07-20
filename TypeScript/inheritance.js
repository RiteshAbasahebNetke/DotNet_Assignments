var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Bill = /** @class */ (function () {
    function Bill(billno, billdate, customername) {
        this.billno = billno;
        this.billdate = billdate;
        this.customername = customername;
    }
    Bill.prototype.DispBill = function () {
        console.log("BillNo is:" + this.billno);
        console.log("Bill Date is:" + this.billdate);
        console.log("CustomerName is:" + this.customername);
    };
    return Bill;
}());
var MobileBill = /** @class */ (function (_super) {
    __extends(MobileBill, _super);
    function MobileBill(billno, billdate, customername, mobileno, noofcalls, callrate) {
        var _this = _super.call(this, billno, billdate, customername) || this;
        _this.mobileno = mobileno;
        _this.noofcalls = noofcalls;
        _this.callrate = callrate;
        return _this;
    }
    MobileBill.prototype.DispMobileBill = function () {
        this.DispBill();
        console.log("MobileNo is:" + this.mobileno);
        console.log("NoOfCalls is:" + this.noofcalls);
        console.log("CallRate is:" + this.callrate);
        console.log("Amount:" + this.noofcalls * this.callrate);
    };
    return MobileBill;
}(Bill));
var mb = new MobileBill(1, "22/10/2023", "Suresh", "765432190", 100, 2);
mb.DispMobileBill();
