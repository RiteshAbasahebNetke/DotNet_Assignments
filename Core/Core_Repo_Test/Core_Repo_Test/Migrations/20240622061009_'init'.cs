using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Repo_Test.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacilityTbl",
                columns: table => new
                {
                    FacilityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityTbl", x => x.FacilityID);
                });

            migrationBuilder.CreateTable(
                name: "FlightsTbl",
                columns: table => new
                {
                    FlightID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceCityID = table.Column<long>(type: "bigint", nullable: false),
                    DestinationCityID = table.Column<long>(type: "bigint", nullable: false),
                    Fair = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TravelTime = table.Column<long>(type: "bigint", nullable: false),
                    IsDirect = table.Column<bool>(type: "bit", nullable: false),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightsTbl", x => x.FlightID);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightsFlightID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_CityTbl_FlightsTbl_FlightsFlightID",
                        column: x => x.FlightsFlightID,
                        principalTable: "FlightsTbl",
                        principalColumn: "FlightID");
                });

            migrationBuilder.CreateTable(
                name: "FacilitiesTbl",
                columns: table => new
                {
                    FlightFeatureID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightID = table.Column<long>(type: "bigint", nullable: false),
                    FacilityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitiesTbl", x => x.FlightFeatureID);
                    table.ForeignKey(
                        name: "FK_FacilitiesTbl_FacilityTbl_FacilityID",
                        column: x => x.FacilityID,
                        principalTable: "FacilityTbl",
                        principalColumn: "FacilityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilitiesTbl_FlightsTbl_FlightID",
                        column: x => x.FlightID,
                        principalTable: "FlightsTbl",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_FlightsFlightID",
                table: "CityTbl",
                column: "FlightsFlightID");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitiesTbl_FacilityID",
                table: "FacilitiesTbl",
                column: "FacilityID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FacilitiesTbl_FlightID",
                table: "FacilitiesTbl",
                column: "FlightID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "FacilitiesTbl");

            migrationBuilder.DropTable(
                name: "FacilityTbl");

            migrationBuilder.DropTable(
                name: "FlightsTbl");
        }
    }
}
