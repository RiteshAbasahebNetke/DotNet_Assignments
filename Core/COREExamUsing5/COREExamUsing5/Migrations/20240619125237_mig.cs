using Microsoft.EntityFrameworkCore.Migrations;

namespace COREExamUsing5.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpTbl",
                columns: table => new
                {
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTbl", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "EmpSalTbl",
                columns: table => new
                {
                    EmpSalaryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpSalTbl", x => x.EmpSalaryID);
                    table.ForeignKey(
                        name: "FK_EmpSalTbl_EmpTbl_EmpID",
                        column: x => x.EmpID,
                        principalTable: "EmpTbl",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalAddTbl",
                columns: table => new
                {
                    SalaryAdditionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalAddTbl", x => x.SalaryAdditionID);
                    table.ForeignKey(
                        name: "FK_SalAddTbl_EmpTbl_EmpID",
                        column: x => x.EmpID,
                        principalTable: "EmpTbl",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalDedTbl",
                columns: table => new
                {
                    SalaryDeductionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeductionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeductionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalDedTbl", x => x.SalaryDeductionID);
                    table.ForeignKey(
                        name: "FK_SalDedTbl_EmpTbl_EmpID",
                        column: x => x.EmpID,
                        principalTable: "EmpTbl",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmpSalTbl_EmpID",
                table: "EmpSalTbl",
                column: "EmpID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalAddTbl_EmpID",
                table: "SalAddTbl",
                column: "EmpID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalDedTbl_EmpID",
                table: "SalDedTbl",
                column: "EmpID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpSalTbl");

            migrationBuilder.DropTable(
                name: "SalAddTbl");

            migrationBuilder.DropTable(
                name: "SalDedTbl");

            migrationBuilder.DropTable(
                name: "EmpTbl");
        }
    }
}
