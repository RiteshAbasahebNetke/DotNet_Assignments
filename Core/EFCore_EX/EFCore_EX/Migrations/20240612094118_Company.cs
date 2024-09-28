using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_EX.Migrations
{
    public partial class Company : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeptTbl",
                columns: table => new
                {
                    DeptID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptTbl", x => x.DeptID);
                });

            migrationBuilder.CreateTable(
                name: "EmpTbl",
                columns: table => new
                {
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeptID = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentDeptID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTbl", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_EmpTbl_DeptTbl_DepartmentDeptID",
                        column: x => x.DepartmentDeptID,
                        principalTable: "DeptTbl",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpTbl_DepartmentDeptID",
                table: "EmpTbl",
                column: "DepartmentDeptID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpTbl");

            migrationBuilder.DropTable(
                name: "DeptTbl");
        }
    }
}
