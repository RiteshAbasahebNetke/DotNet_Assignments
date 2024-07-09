namespace code_first_ex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmpTbl", "JoinDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmpTbl", "JoinDate");
        }
    }
}
