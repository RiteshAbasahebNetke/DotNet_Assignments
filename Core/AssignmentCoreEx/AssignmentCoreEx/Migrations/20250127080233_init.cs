using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssignmentCoreEx.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorTbl",
                columns: table => new
                {
                    ColorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTbl", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "MfgTbl",
                columns: table => new
                {
                    MfgID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MfgTbl", x => x.MfgID);
                });

            migrationBuilder.CreateTable(
                name: "ProCatTbl",
                columns: table => new
                {
                    ProductCategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProCatTbl", x => x.ProductCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ProductTbl",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    ColorID = table.Column<long>(type: "bigint", nullable: false),
                    MfgID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTbl", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_ProductTbl_ColorTbl_ColorID",
                        column: x => x.ColorID,
                        principalTable: "ColorTbl",
                        principalColumn: "ColorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTbl_MfgTbl_MfgID",
                        column: x => x.MfgID,
                        principalTable: "MfgTbl",
                        principalColumn: "MfgID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTbl_ProCatTbl_ProductCategoryID",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProCatTbl",
                        principalColumn: "ProductCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ColorTbl",
                columns: new[] { "ColorID", "ColorName" },
                values: new object[,]
                {
                    { 1L, "Red" },
                    { 2L, "Black" },
                    { 3L, "Violet" },
                    { 4L, "Brown" }
                });

            migrationBuilder.InsertData(
                table: "MfgTbl",
                columns: new[] { "MfgID", "Address", "EmailID", "MfgName", "MobileNo" },
                values: new object[,]
                {
                    { 1L, "Wagholi", "intex@gmail.com", "Intex", "120946573" },
                    { 2L, "Pimpri", "polo@gmail.com", "Polo", "120946573" },
                    { 3L, "Baner", "samsunng@gmail.com", "Samsung", "120046573" },
                    { 4L, "Chinchwad", "denim@gmail.com", "Denim", "120906573" }
                });

            migrationBuilder.InsertData(
                table: "ProCatTbl",
                columns: new[] { "ProductCategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Computer" },
                    { 2L, "Cloths" },
                    { 3L, "Electronics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTbl_ColorID",
                table: "ProductTbl",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTbl_MfgID",
                table: "ProductTbl",
                column: "MfgID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTbl_ProductCategoryID",
                table: "ProductTbl",
                column: "ProductCategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTbl");

            migrationBuilder.DropTable(
                name: "ColorTbl");

            migrationBuilder.DropTable(
                name: "MfgTbl");

            migrationBuilder.DropTable(
                name: "ProCatTbl");
        }
    }
}
