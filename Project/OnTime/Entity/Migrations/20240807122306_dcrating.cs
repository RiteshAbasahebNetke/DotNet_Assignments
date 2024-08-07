using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class dcrating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "DoctorRatingTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "ClinicRatingTbl",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "ClinicRatingTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorRatingTbl_UserID",
                table: "DoctorRatingTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicRatingTbl_UserID",
                table: "ClinicRatingTbl",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicRatingTbl_UserTbl_UserID",
                table: "ClinicRatingTbl",
                column: "UserID",
                principalTable: "UserTbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorRatingTbl_UserTbl_UserID",
                table: "DoctorRatingTbl",
                column: "UserID",
                principalTable: "UserTbl",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClinicRatingTbl_UserTbl_UserID",
                table: "ClinicRatingTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorRatingTbl_UserTbl_UserID",
                table: "DoctorRatingTbl");

            migrationBuilder.DropIndex(
                name: "IX_DoctorRatingTbl_UserID",
                table: "DoctorRatingTbl");

            migrationBuilder.DropIndex(
                name: "IX_ClinicRatingTbl_UserID",
                table: "ClinicRatingTbl");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "DoctorRatingTbl");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "ClinicRatingTbl");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ClinicRatingTbl");
        }
    }
}
