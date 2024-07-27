using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity.Migrations
{
    /// <inheritdoc />
    public partial class model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityTbl_StateTbl_StateID",
                table: "CityTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_StateTbl_CountryTbl_CountryID",
                table: "StateTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "AdminTbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminTbl",
                table: "AdminTbl",
                column: "AdminID");

            migrationBuilder.CreateTable(
                name: "AreaTbl",
                columns: table => new
                {
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaTbl", x => x.AreaID);
                    table.ForeignKey(
                        name: "FK_AreaTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicTbl",
                columns: table => new
                {
                    ClinicID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandLineNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicTbl", x => x.ClinicID);
                    table.ForeignKey(
                        name: "FK_ClinicTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecilityTbl",
                columns: table => new
                {
                    SpecilityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecilityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecilityTbl", x => x.SpecilityID);
                });

            migrationBuilder.CreateTable(
                name: "UserTbl",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTbl", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserTbl_CountryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorTbl",
                columns: table => new
                {
                    DoctorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorQualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorTbl", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_DoctorTbl_AreaTbl_AreaID",
                        column: x => x.AreaID,
                        principalTable: "AreaTbl",
                        principalColumn: "AreaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicCertificateTbl",
                columns: table => new
                {
                    ClinicCertificateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClinicID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicCertificateTbl", x => x.ClinicCertificateID);
                    table.ForeignKey(
                        name: "FK_ClinicCertificateTbl_ClinicTbl_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "ClinicTbl",
                        principalColumn: "ClinicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicFacilityTbl",
                columns: table => new
                {
                    ClinicFacilityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicFacilityTbl", x => x.ClinicFacilityID);
                    table.ForeignKey(
                        name: "FK_ClinicFacilityTbl_ClinicTbl_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "ClinicTbl",
                        principalColumn: "ClinicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClinicRatingTbl",
                columns: table => new
                {
                    ClinicRatingID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ClinicID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicRatingTbl", x => x.ClinicRatingID);
                    table.ForeignKey(
                        name: "FK_ClinicRatingTbl_ClinicTbl_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "ClinicTbl",
                        principalColumn: "ClinicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPDSessionTbl",
                columns: table => new
                {
                    OpdSessionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPDSessionTbl", x => x.OpdSessionID);
                    table.ForeignKey(
                        name: "FK_OPDSessionTbl_ClinicTbl_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "ClinicTbl",
                        principalColumn: "ClinicID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientTbl",
                columns: table => new
                {
                    PatientID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTbl", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_PatientTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorRatingTbl",
                columns: table => new
                {
                    DoctorRatingID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorRatingTbl", x => x.DoctorRatingID);
                    table.ForeignKey(
                        name: "FK_DoctorRatingTbl_DoctorTbl_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "DoctorTbl",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSpecialityTbl",
                columns: table => new
                {
                    DoctorSpecilityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorID = table.Column<long>(type: "bigint", nullable: false),
                    SpecilityID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecialityTbl", x => x.DoctorSpecilityID);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialityTbl_DoctorTbl_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "DoctorTbl",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorSpecialityTbl_SpecilityTbl_SpecilityID",
                        column: x => x.SpecilityID,
                        principalTable: "SpecilityTbl",
                        principalColumn: "SpecilityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorClinicSessionTbl",
                columns: table => new
                {
                    DoctorClinicSessionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeInterval = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<long>(type: "bigint", nullable: false),
                    ClinicID = table.Column<long>(type: "bigint", nullable: false),
                    OpdSessionID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorClinicSessionTbl", x => x.DoctorClinicSessionID);
                    table.ForeignKey(
                        name: "FK_DoctorClinicSessionTbl_ClinicTbl_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "ClinicTbl",
                        principalColumn: "ClinicID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorClinicSessionTbl_DoctorTbl_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "DoctorTbl",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DoctorClinicSessionTbl_OPDSessionTbl_OpdSessionID",
                        column: x => x.OpdSessionID,
                        principalTable: "OPDSessionTbl",
                        principalColumn: "OpdSessionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookedAppointmentsTbl",
                columns: table => new
                {
                    BookedAppointmentsID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaid = table.Column<long>(type: "bigint", nullable: false),
                    DoctorClinicSessionID = table.Column<long>(type: "bigint", nullable: false),
                    PatientID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedAppointmentsTbl", x => x.BookedAppointmentsID);
                    table.ForeignKey(
                        name: "FK_BookedAppointmentsTbl_DoctorClinicSessionTbl_DoctorClinicSessionID",
                        column: x => x.DoctorClinicSessionID,
                        principalTable: "DoctorClinicSessionTbl",
                        principalColumn: "DoctorClinicSessionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookedAppointmentsTbl_PatientTbl_PatientID",
                        column: x => x.PatientID,
                        principalTable: "PatientTbl",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookedAppPaymentTbl",
                columns: table => new
                {
                    BookedAppPaymentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMode = table.Column<int>(type: "int", nullable: false),
                    BookedAppointmentsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedAppPaymentTbl", x => x.BookedAppPaymentID);
                    table.ForeignKey(
                        name: "FK_BookedAppPaymentTbl_BookedAppointmentsTbl_BookedAppointmentsID",
                        column: x => x.BookedAppointmentsID,
                        principalTable: "BookedAppointmentsTbl",
                        principalColumn: "BookedAppointmentsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaTbl_CityID",
                table: "AreaTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointmentsTbl_DoctorClinicSessionID",
                table: "BookedAppointmentsTbl",
                column: "DoctorClinicSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppointmentsTbl_PatientID",
                table: "BookedAppointmentsTbl",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_BookedAppPaymentTbl_BookedAppointmentsID",
                table: "BookedAppPaymentTbl",
                column: "BookedAppointmentsID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicCertificateTbl_ClinicID",
                table: "ClinicCertificateTbl",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicFacilityTbl_ClinicID",
                table: "ClinicFacilityTbl",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicRatingTbl_ClinicID",
                table: "ClinicRatingTbl",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicTbl_CityID",
                table: "ClinicTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinicSessionTbl_ClinicID",
                table: "DoctorClinicSessionTbl",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinicSessionTbl_DoctorID",
                table: "DoctorClinicSessionTbl",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClinicSessionTbl_OpdSessionID",
                table: "DoctorClinicSessionTbl",
                column: "OpdSessionID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorRatingTbl_DoctorID",
                table: "DoctorRatingTbl",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialityTbl_DoctorID",
                table: "DoctorSpecialityTbl",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorSpecialityTbl_SpecilityID",
                table: "DoctorSpecialityTbl",
                column: "SpecilityID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorTbl_AreaID",
                table: "DoctorTbl",
                column: "AreaID");

            migrationBuilder.CreateIndex(
                name: "IX_OPDSessionTbl_ClinicID",
                table: "OPDSessionTbl",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTbl_UserID",
                table: "PatientTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTbl_CountryID",
                table: "UserTbl",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_CityTbl_StateTbl_StateID",
                table: "CityTbl",
                column: "StateID",
                principalTable: "StateTbl",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StateTbl_CountryTbl_CountryID",
                table: "StateTbl",
                column: "CountryID",
                principalTable: "CountryTbl",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.DropTable(
                name: "BookedAppPaymentTbl");

            migrationBuilder.DropTable(
                name: "ClinicCertificateTbl");

            migrationBuilder.DropTable(
                name: "ClinicFacilityTbl");

            migrationBuilder.DropTable(
                name: "ClinicRatingTbl");

            migrationBuilder.DropTable(
                name: "DoctorRatingTbl");

            migrationBuilder.DropTable(
                name: "DoctorSpecialityTbl");

            migrationBuilder.DropTable(
                name: "BookedAppointmentsTbl");

            migrationBuilder.DropTable(
                name: "SpecilityTbl");

            migrationBuilder.DropTable(
                name: "DoctorClinicSessionTbl");

            migrationBuilder.DropTable(
                name: "PatientTbl");

            migrationBuilder.DropTable(
                name: "DoctorTbl");

            migrationBuilder.DropTable(
                name: "OPDSessionTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");

            migrationBuilder.DropTable(
                name: "AreaTbl");

            migrationBuilder.DropTable(
                name: "ClinicTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminTbl",
                table: "AdminTbl");

            migrationBuilder.RenameTable(
                name: "AdminTbl",
                newName: "Admins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminID");

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
    }
}
