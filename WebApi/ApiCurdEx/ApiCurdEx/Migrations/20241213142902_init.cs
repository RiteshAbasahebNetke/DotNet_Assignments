using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCurdEx.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTbl",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTbl", x => x.CustomerID);
                });

            migrationBuilder.InsertData(
                table: "CustomerTbl",
                columns: new[] { "CustomerID", "Address", "CreditLimit", "CustomerName", "EmailAddress", "MobileNo" },
                values: new object[] { 1L, "Nigdi", 15000m, "Ramesh", "ramesh@gmail.com", "98765403" });

            migrationBuilder.InsertData(
                table: "CustomerTbl",
                columns: new[] { "CustomerID", "Address", "CreditLimit", "CustomerName", "EmailAddress", "MobileNo" },
                values: new object[] { 2L, "Akurdi", 13000m, "Sham", "sham@gmail.com", "99765403" });

            migrationBuilder.InsertData(
                table: "CustomerTbl",
                columns: new[] { "CustomerID", "Address", "CreditLimit", "CustomerName", "EmailAddress", "MobileNo" },
                values: new object[] { 3L, "Wakad", 10000m, "Raju", "raju@gmail.com", "98765483" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTbl");
        }
    }
}
