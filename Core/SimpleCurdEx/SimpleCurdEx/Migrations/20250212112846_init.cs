﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleCurdEx.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeptTbl",
                columns: table => new
                {
                    DeptID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptTbl", x => x.DeptID);
                });

            migrationBuilder.CreateTable(
                name: "EmpTbl",
                columns: table => new
                {
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DeptID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTbl", x => x.EmpID);
                    table.ForeignKey(
                        name: "FK_EmpTbl_DeptTbl_DeptID",
                        column: x => x.DeptID,
                        principalTable: "DeptTbl",
                        principalColumn: "DeptID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DeptTbl",
                columns: new[] { "DeptID", "DeptName" },
                values: new object[,]
                {
                    { 1L, "Computer" },
                    { 2L, "Sales" },
                    { 3L, "Purchase" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpTbl_DeptID",
                table: "EmpTbl",
                column: "DeptID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpTbl");

            migrationBuilder.DropTable(
                name: "DeptTbl");
        }
    }
}
