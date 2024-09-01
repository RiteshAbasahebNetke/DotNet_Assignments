using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentPrescription",
                columns: table => new
                {
                    AppointmentPrescriptionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prescription = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DoctorID = table.Column<long>(type: "bigint", nullable: false),
                    BookedAppointmentsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentPrescription", x => x.AppointmentPrescriptionID);
                    table.ForeignKey(
                        name: "FK_AppointmentPrescription_BookedAppointmentsTbl_BookedAppointmentsID",
                        column: x => x.BookedAppointmentsID,
                        principalTable: "BookedAppointmentsTbl",
                        principalColumn: "BookedAppointmentsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AppointmentPrescription_DoctorTbl_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "DoctorTbl",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicineTbl",
                columns: table => new
                {
                    MedicineID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenericName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineTbl", x => x.MedicineID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentPrescriptionDetailsTbl",
                columns: table => new
                {
                    AppointmentPrescriptionDetailsID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitEnum = table.Column<int>(type: "int", nullable: false),
                    FrequencyEnum = table.Column<int>(type: "int", nullable: false),
                    MedidcineID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentPrescriptionDetailsTbl", x => x.AppointmentPrescriptionDetailsID);
                    table.ForeignKey(
                        name: "FK_AppointmentPrescriptionDetailsTbl_MedicineTbl_MedidcineID",
                        column: x => x.MedidcineID,
                        principalTable: "MedicineTbl",
                        principalColumn: "MedicineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentPrescription_BookedAppointmentsID",
                table: "AppointmentPrescription",
                column: "BookedAppointmentsID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentPrescription_DoctorID",
                table: "AppointmentPrescription",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentPrescriptionDetailsTbl_MedidcineID",
                table: "AppointmentPrescriptionDetailsTbl",
                column: "MedidcineID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentPrescription");

            migrationBuilder.DropTable(
                name: "AppointmentPrescriptionDetailsTbl");

            migrationBuilder.DropTable(
                name: "MedicineTbl");
        }
    }
}
