﻿// <auto-generated />
using Core_Curd_EX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core_Curd_EX.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20240710115418_model")]
    partial class model
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

            modelBuilder.Entity("Core_Curd_EX.Models.Area", b =>
                {
                    b.Property<long>("AreaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AreaID"));

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AreaID");

                    b.ToTable("AreaTbl");

                    b.HasData(
                        new
                        {
                            AreaID = 1L,
                            AreaName = "Pimpri"
                        },
                        new
                        {
                            AreaID = 2L,
                            AreaName = "Chinchwad"
                        },
                        new
                        {
                            AreaID = 3L,
                            AreaName = "Nigdi"
                        },
                        new
                        {
                            AreaID = 4L,
                            AreaName = "Akurdi"
                        });
                });

            modelBuilder.Entity("Core_Curd_EX.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerID"));

                    b.Property<long>("AreaID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("CreditLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.HasIndex("AreaID");

                    b.ToTable("CustomerTbl");
                });

            modelBuilder.Entity("Core_Curd_EX.Models.Customer", b =>
                {
                    b.HasOne("Core_Curd_EX.Models.Area", "Area")
                        .WithMany("Customer")
                        .HasForeignKey("AreaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Core_Curd_EX.Models.Area", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}