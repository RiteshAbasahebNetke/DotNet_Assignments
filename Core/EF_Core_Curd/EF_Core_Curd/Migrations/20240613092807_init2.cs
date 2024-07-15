using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Curd.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdcutCategoryID",
                table: "ProdCatTbl",
                newName: "ProductCategoryID");

            migrationBuilder.AddColumn<int>(
                name: "ProductColor",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductColor",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryID",
                table: "ProdCatTbl",
                newName: "ProdcutCategoryID");
        }
    }
}
