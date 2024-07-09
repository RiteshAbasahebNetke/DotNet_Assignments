namespace code_first_ex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeptTbl",
                c => new
                    {
                        DID = c.Long(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DID);
            
            CreateTable(
                "dbo.EmpTbl",
                c => new
                    {
                        EmpID = c.Long(nullable: false, identity: true),
                        EmpName = c.String(),
                        EmailID = c.String(),
                        MobileNo = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeptID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.EmpID)
                .ForeignKey("dbo.DeptTbl", t => t.DeptID, cascadeDelete: true)
                .Index(t => t.DeptID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpTbl", "DeptID", "dbo.DeptTbl");
            DropIndex("dbo.EmpTbl", new[] { "DeptID" });
            DropTable("dbo.EmpTbl");
            DropTable("dbo.DeptTbl");
        }
    }
}
