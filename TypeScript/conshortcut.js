var Product = /** @class */ (function () {
    function Product(ProductId, ProductName, MfgName, Price) {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.MfgName = MfgName;
        this.Price = Price;
    }
    Product.prototype.DispProduct = function () {
        console.log("ProductId is:" + this.ProductId);
        console.log("ProductName is:" + this.ProductName);
        console.log("MfgName is:" + this.MfgName);
        console.log("Price is:" + this.Price);
    };
    return Product;
}());
var p = new Product(1, 'Mouse', 'Intex', 780);
p.DispProduct();
