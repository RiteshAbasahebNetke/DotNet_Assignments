using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CurdUsing_6Version.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DeptTbl",
                columns: new[] { "DeptID", "DeptName" },
                values: new object[,]
                {
                    { 1L, "Computer" },
                    { 2L, "HR" },
                    { 3L, "Process" }
                });

            migrationBuilder.InsertData(
                table: "EmpTbl",
                columns: new[] { "EmpID", "Address", "DeptID", "EmailID", "EmpName", "Salary" },
                values: new object[,]
                {
                    { 1L, "Akurdi", 2L, "suresh@gmail.com", "Suresh", 23000m },
                    { 2L, "Pimpri", 3L, "manish@hotmail.com", "Manish", 27000m },
                    { 3L, "Nigdi", 1L, "raj@gmail.com", "Raj", 33000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "EmpTbl",
                keyColumn: "EmpID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DeptTbl",
                keyColumn: "DeptID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DeptTbl",
                keyColumn: "DeptID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DeptTbl",
                keyColumn: "DeptID",
                keyValue: 3L);
        }
    }
}
