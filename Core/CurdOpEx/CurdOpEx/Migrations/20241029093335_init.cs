﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurdOpEx.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryTbl",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTbl", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ProductTbl",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTbl", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_ProductTbl_CategoryTbl_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryTbl",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryTbl",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1L, "Electronics" });

            migrationBuilder.InsertData(
                table: "CategoryTbl",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2L, "Computer" });

            migrationBuilder.InsertData(
                table: "CategoryTbl",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3L, "Books" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTbl_CategoryID",
                table: "ProductTbl",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTbl");

            migrationBuilder.DropTable(
                name: "CategoryTbl");
        }
    }
}