using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CURD_Repo_6.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubTbl",
                columns: table => new
                {
                    SubjectID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTbl", x => x.SubjectID);
                });

            migrationBuilder.CreateTable(
                name: "BookTbl",
                columns: table => new
                {
                    BookID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubjectID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookTbl", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_BookTbl_SubTbl_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "SubTbl",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SubTbl",
                columns: new[] { "SubjectID", "SubjectName" },
                values: new object[,]
                {
                    { 1L, "Marathi" },
                    { 2L, "GK" },
                    { 3L, "Algebra" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookTbl_SubjectID",
                table: "BookTbl",
                column: "SubjectID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookTbl");

            migrationBuilder.DropTable(
                name: "SubTbl");
        }
    }
}
