using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace curdEX.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepTbl",
                columns: table => new
                {
                    DeptID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepTbl", x => x.DeptID);
                });

            migrationBuilder.CreateTable(
                name: "EmpTbl",
                columns: table => new
                {
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeptID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTbl", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_EmpTbl_DepTbl_DeptID",
                        column: x => x.DeptID,
                        principalTable: "DepTbl",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DepTbl",
                columns: new[] { "DeptID", "DeptName" },
                values: new object[] { 1L, "Sales" });

            migrationBuilder.InsertData(
                table: "DepTbl",
                columns: new[] { "DeptID", "DeptName" },
                values: new object[] { 2L, "Computer" });

            migrationBuilder.InsertData(
                table: "DepTbl",
                columns: new[] { "DeptID", "DeptName" },
                values: new object[] { 3L, "Marketing" });

            migrationBuilder.CreateIndex(
                name: "IX_EmpTbl_DeptID",
                table: "EmpTbl",
                column: "DeptID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpTbl");

            migrationBuilder.DropTable(
                name: "DepTbl");
        }
    }
}
