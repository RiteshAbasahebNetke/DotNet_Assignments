using Microsoft.EntityFrameworkCore;

namespace ViewCompEx.Models
{
    public class VContext:DbContext
    {
        public VContext(DbContextOptions<VContext>opt):base(opt) { }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Emp>().HasData(
                new Emp() { EmpID = 1, EmpName = "Ramesh", DeptName = "Computer", Salary = 34000 },
                new Emp() { EmpID=2, EmpName="Sunil",DeptName="Sales",Salary=54000},
                new Emp() { EmpID=3, EmpName="Raj",DeptName="Sales",Salary=70000},
                new Emp() { EmpID=4,EmpName="Sham",DeptName="Computer",Salary=75000}
                );

            mb.Entity<Product>().HasData(
                new Product() { ProductID=1, ProductName="Mouse", MfgName="Dell",Price=670},
                new Product() { ProductID=2, ProductName="KeyBoard", MfgName="Intex",Price=1230},
                new Product() { ProductID=3,ProductName="Monitor",MfgName="LG",Price=8990}
                );

            mb.Entity<Book>().HasData(
                new Book() { BookID=1,BookName="BalBharti",AuthorName="Pune Board",Price=88},
                new Book() { BookID=2,BookName="Geometry",AuthorName="Pune Board",Price=170}
                );
        }
        //public List<Emp> Emps { get; set; }
        //public List<Product> Products { get; set; }
        //public List<Book> Books { get; set; }       

        public DbSet<Emp> Emps { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<Book> Books { set; get; }
    }
}
