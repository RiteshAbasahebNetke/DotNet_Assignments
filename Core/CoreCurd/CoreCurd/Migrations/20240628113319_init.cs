using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoreCurd.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "BusTbl",
                columns: table => new
                {
                    BusID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusTbl", x => x.BusID);
                    table.ForeignKey(
                        name: "FK_BusTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CityTbl",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { 1L, "Pune" },
                    { 2L, "Nashik" },
                    { 3L, "Nagar" },
                    { 4L, "Satara" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusTbl_CityID",
                table: "BusTbl",
                column: "CityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusTbl");

            migrationBuilder.DropTable(
                name: "CityTbl");
        }
    }
}
