using Microsoft.EntityFrameworkCore.Migrations;

namespace RepoCURD.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmpTbl",
                columns: new[] { "EmpID", "DeptID", "EmailID", "EmpName", "Salary" },
                values: new object[] { 10L, 0L, "sham@gmail.com", "Sham", 40000m });

            migrationBuilder.InsertData(
                table: "EmpTbl",
                columns: new[] { "EmpID", "DeptID", "EmailID", "EmpName", "Salary" },
                values: new object[] { 23L, 0L, "ram@hotmail.com", "Ram", 35000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 23L);
        }
    }
}
