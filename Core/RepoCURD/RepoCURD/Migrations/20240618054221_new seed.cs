using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoCURD.Migrations
{
    public partial class newseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 10L,
                column: "DeptID",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 23L,
                column: "DeptID",
                value: 1L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 10L,
                column: "DeptID",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 23L,
                column: "DeptID",
                value: 0L);
        }
    }
}
