using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class stateupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_CountryTbl_CountryID",
                table: "States");

            migrationBuilder.DropTable(
                name: "CityState");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "StateTbl");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "CityTbl");

            migrationBuilder.RenameIndex(
                name: "IX_States_CountryID",
                table: "StateTbl",
                newName: "IX_StateTbl_CountryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateTbl",
                table: "StateTbl",
                column: "StateID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityTbl",
                table: "CityTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.AddForeignKey(
                name: "FK_CityTbl_StateTbl_StateID",
                table: "CityTbl",
                column: "StateID",
                principalTable: "StateTbl",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StateTbl_CountryTbl_CountryID",
                table: "StateTbl",
                column: "CountryID",
                principalTable: "CountryTbl",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityTbl_StateTbl_StateID",
                table: "CityTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StateTbl_CountryTbl_CountryID",
                table: "StateTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateTbl",
                table: "StateTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityTbl",
                table: "CityTbl");

            migrationBuilder.DropIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl");

            migrationBuilder.RenameTable(
                name: "StateTbl",
                newName: "States");

            migrationBuilder.RenameTable(
                name: "CityTbl",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_StateTbl_CountryID",
                table: "States",
                newName: "IX_States_CountryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "StateID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "CityID");

            migrationBuilder.CreateTable(
                name: "CityState",
                columns: table => new
                {
                    CitiesCityID = table.Column<long>(type: "bigint", nullable: false),
                    StatesStateID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityState", x => new { x.CitiesCityID, x.StatesStateID });
                    table.ForeignKey(
                        name: "FK_CityState_Cities_CitiesCityID",
                        column: x => x.CitiesCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityState_States_StatesStateID",
                        column: x => x.StatesStateID,
                        principalTable: "States",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityState_StatesStateID",
                table: "CityState",
                column: "StatesStateID");

            migrationBuilder.AddForeignKey(
                name: "FK_States_CountryTbl_CountryID",
                table: "States",
                column: "CountryID",
                principalTable: "CountryTbl",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
