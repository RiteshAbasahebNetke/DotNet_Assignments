using CoreCurdUsingDIEx.Models;

namespace CoreCurdUsingDIEx.Repositories
{
    public class ProductRepo : IProductRepo
    {
        CompanyContext cc;
        public ProductRepo(CompanyContext cc)
        {
            this.cc = cc;
        }

        public void Add(Product rec)
        {
            this.cc.Products.Add(rec);
            this.cc.SaveChanges();
        }

        public void Delete(long id)
        {
            var rec=this.cc.Products.Find(id);
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
        }

        public void Edit(Product rec)
        {
             var oldrec=this.cc.Products.Find(rec.ProductID);
            oldrec.ProductID = rec.ProductID;
            oldrec.ProductName = rec.ProductName;   
            oldrec.MfgName = rec.MfgName;
            oldrec.CategoryID = rec.CategoryID;
            oldrec.Price=rec.Price;
            this.cc.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return this.cc.Products.ToList();
        }

        public Product GetByID(long id)
        {
            return this.cc.Products.Find(id);
        }
    }
}
