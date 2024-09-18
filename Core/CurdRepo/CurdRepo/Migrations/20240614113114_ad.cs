using Microsoft.EntityFrameworkCore.Migrations;

namespace CurdRepo.Migrations
{
    public partial class ad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryTbl",
                columns: table => new
                {
                    CourseCategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTbl", x => x.CourseCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CourseTbl",
                columns: table => new
                {
                    CourseID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationInMonths = table.Column<int>(type: "int", nullable: false),
                    CourseCategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTbl", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_CourseTbl_CategoryTbl_CourseCategoryID",
                        column: x => x.CourseCategoryID,
                        principalTable: "CategoryTbl",
                        principalColumn: "CourseCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTbl_CourseCategoryID",
                table: "CourseTbl",
                column: "CourseCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseTbl");

            migrationBuilder.DropTable(
                name: "CategoryTbl");
        }
    }
}
