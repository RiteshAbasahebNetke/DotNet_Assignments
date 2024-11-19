using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DependentDropDownEX.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryTbl",
                columns: table => new
                {
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTbl", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "StateTbl",
                columns: table => new
                {
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTbl", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_StateTbl_CountryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_CityTbl_StateTbl_StateID",
                        column: x => x.StateID,
                        principalTable: "StateTbl",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CountryTbl",
                columns: new[] { "CountryID", "CountryName" },
                values: new object[] { 1L, "India" });

            migrationBuilder.InsertData(
                table: "CountryTbl",
                columns: new[] { "CountryID", "CountryName" },
                values: new object[] { 2L, "USA" });

            migrationBuilder.InsertData(
                table: "CountryTbl",
                columns: new[] { "CountryID", "CountryName" },
                values: new object[] { 3L, "Japan" });

            migrationBuilder.InsertData(
                table: "StateTbl",
                columns: new[] { "StateID", "CountryID", "StateName" },
                values: new object[,]
                {
                    { 1L, 1L, "Maharashtra" },
                    { 2L, 1L, "Karnataka" },
                    { 3L, 2L, "California" },
                    { 4L, 2L, "Texas" },
                    { 5L, 3L, "Hokkaido" },
                    { 6L, 3L, "Shikoku" }
                });

            migrationBuilder.InsertData(
                table: "CityTbl",
                columns: new[] { "CityID", "CityName", "StateID" },
                values: new object[,]
                {
                    { 1L, "Mumbai", 1L },
                    { 2L, "Pune", 1L },
                    { 3L, "PCMC", 1L },
                    { 4L, "Bengluru", 2L },
                    { 5L, "Mangaluru", 2L },
                    { 6L, "Kalburga", 2L },
                    { 7L, "Los Aneles", 3L },
                    { 8L, "San Francisco", 3L },
                    { 9L, "Hostun", 4L },
                    { 10L, "Dallas", 4L },
                    { 11L, "Sapporo", 5L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_StateTbl_CountryID",
                table: "StateTbl",
                column: "CountryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "StateTbl");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}
