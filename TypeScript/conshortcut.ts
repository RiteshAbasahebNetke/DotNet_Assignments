class Product
{
   constructor(
    private ProductId:number,
    private ProductName:string,
    private MfgName:string,
    private Price:number) 
    {}

    public DispProduct()
    {
        console.log("ProductId is:" + this.ProductId);
        console.log("ProductName is:" + this.ProductName);
        console.log("MfgName is:" + this.MfgName);
        console.log("Price is:" + this.Price);
    }
}
var p=new Product(1,'Mouse','Intex',780);
p.DispProduct();