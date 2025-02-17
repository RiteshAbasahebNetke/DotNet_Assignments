﻿// <auto-generated />
using CurdIn6._0.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CurdIn6._0.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240618105219_ini")]
    partial class ini
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CurdIn6._0.Models.Dept", b =>
                {
                    b.Property<long>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DeptID"));

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptID");

                    b.ToTable("DeptTbl");
                });

            modelBuilder.Entity("CurdIn6._0.Models.Emp", b =>
                {
                    b.Property<long>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmpID"));

                    b.Property<long>("DeptID")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmpID");

                    b.HasIndex("DeptID");

                    b.ToTable("EmpTbl");
                });

            modelBuilder.Entity("CurdIn6._0.Models.Emp", b =>
                {
                    b.HasOne("CurdIn6._0.Models.Dept", "Department")
                        .WithMany("Emps")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("CurdIn6._0.Models.Dept", b =>
                {
                    b.Navigation("Emps");
                });
#pragma warning restore 612, 618
        }
    }
}
