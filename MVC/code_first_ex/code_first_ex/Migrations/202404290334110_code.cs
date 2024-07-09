namespace code_first_ex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class code : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        AreaId = c.Long(nullable: false, identity: true),
                        AreaName = c.String(),
                        EmpArea_AreaId = c.Long(),
                    })
                .PrimaryKey(t => t.AreaId)
                .ForeignKey("dbo.Areas", t => t.EmpArea_AreaId)
                .Index(t => t.EmpArea_AreaId);
            
            AddColumn("dbo.DeptTbl", "Area_AreaId", c => c.Long());
            CreateIndex("dbo.DeptTbl", "Area_AreaId");
            AddForeignKey("dbo.DeptTbl", "Area_AreaId", "dbo.Areas", "AreaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Areas", "EmpArea_AreaId", "dbo.Areas");
            DropForeignKey("dbo.DeptTbl", "Area_AreaId", "dbo.Areas");
            DropIndex("dbo.DeptTbl", new[] { "Area_AreaId" });
            DropIndex("dbo.Areas", new[] { "EmpArea_AreaId" });
            DropColumn("dbo.DeptTbl", "Area_AreaId");
            DropTable("dbo.Areas");
        }
    }
}
