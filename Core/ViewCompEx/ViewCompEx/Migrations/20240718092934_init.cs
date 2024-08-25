using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VIewCompEx.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "products",
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
                    table.PrimaryKey("PK_products", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Emps",
                columns: new[] { "EmpID", "DeptName", "EmpName", "Salary" },
                values: new object[,]
                {
                    { 1L, "Computer", "Sunil", 34000m },
                    { 2L, "Sales", "Ramesh", 67000m },
                    { 3L, "Purchase", "Vilas", 51000m },
                    { 4L, "Production", "Vikas", 23000m }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductID", "MfgName", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1L, "Intex", 450m, "Mouse" },
                    { 2L, "Mi", 780m, "Charger" },
                    { 3L, "Dell", 1450m, "Keyboard" },
                    { 4L, "Seggate", 4450m, "HardDisk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
