using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CurdAPIJan21.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductTbl",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTbl", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "ProductTbl",
                columns: new[] { "ProductID", "MfgName", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1L, "Intex", 450m, "Mouse" },
                    { 2L, "Mi", 780m, "Charger" },
                    { 3L, "HP", 6700m, "Printer" },
                    { 4L, "Seggate", 4500m, "HardDisk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTbl");
        }
    }
}
