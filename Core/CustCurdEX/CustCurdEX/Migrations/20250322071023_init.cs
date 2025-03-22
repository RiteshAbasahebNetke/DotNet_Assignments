using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustCurdEX.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areatbl",
                columns: table => new
                {
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areatbl", x => x.AreaID);
                });

            migrationBuilder.CreateTable(
                name: "CustTbl",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustTbl", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_CustTbl_Areatbl_AreaID",
                        column: x => x.AreaID,
                        principalTable: "Areatbl",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areatbl",
                columns: new[] { "AreaID", "AreaName" },
                values: new object[,]
                {
                    { 1L, "Akurdi" },
                    { 2L, "Pimpri" },
                    { 3L, "Nigdi" },
                    { 4L, "Wakad" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustTbl_AreaID",
                table: "CustTbl",
                column: "AreaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustTbl");

            migrationBuilder.DropTable(
                name: "Areatbl");
        }
    }
}
