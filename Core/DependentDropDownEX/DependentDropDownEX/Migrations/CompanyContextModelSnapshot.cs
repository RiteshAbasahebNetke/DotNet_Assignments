﻿// <auto-generated />
using DependentDropDownEX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DependentDropDownEX.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DependentDropDownEX.Models.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CityID"), 1L, 1);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("CityTbl");

                    b.HasData(
                        new
                        {
                            CityID = 1L,
                            CityName = "Mumbai",
                            StateID = 1L
                        },
                        new
                        {
                            CityID = 2L,
                            CityName = "Pune",
                            StateID = 1L
                        },
                        new
                        {
                            CityID = 3L,
                            CityName = "PCMC",
                            StateID = 1L
                        },
                        new
                        {
                            CityID = 4L,
                            CityName = "Bengluru",
                            StateID = 2L
                        },
                        new
                        {
                            CityID = 5L,
                            CityName = "Mangaluru",
                            StateID = 2L
                        },
                        new
                        {
                            CityID = 6L,
                            CityName = "Kalburga",
                            StateID = 2L
                        },
                        new
                        {
                            CityID = 7L,
                            CityName = "Los Aneles",
                            StateID = 3L
                        },
                        new
                        {
                            CityID = 8L,
                            CityName = "San Francisco",
                            StateID = 3L
                        },
                        new
                        {
                            CityID = 9L,
                            CityName = "Hostun",
                            StateID = 4L
                        },
                        new
                        {
                            CityID = 10L,
                            CityName = "Dallas",
                            StateID = 4L
                        },
                        new
                        {
                            CityID = 11L,
                            CityName = "Sapporo",
                            StateID = 5L
                        });
                });

            modelBuilder.Entity("DependentDropDownEX.Models.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CountryID"), 1L, 1);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("CountryTbl");

                    b.HasData(
                        new
                        {
                            CountryID = 1L,
                            CountryName = "India"
                        },
                        new
                        {
                            CountryID = 2L,
                            CountryName = "USA"
                        },
                        new
                        {
                            CountryID = 3L,
                            CountryName = "Japan"
                        });
                });

            modelBuilder.Entity("DependentDropDownEX.Models.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StateID"), 1L, 1);

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("StateTbl");

                    b.HasData(
                        new
                        {
                            StateID = 1L,
                            CountryID = 1L,
                            StateName = "Maharashtra"
                        },
                        new
                        {
                            StateID = 2L,
                            CountryID = 1L,
                            StateName = "Karnataka"
                        },
                        new
                        {
                            StateID = 3L,
                            CountryID = 2L,
                            StateName = "California"
                        },
                        new
                        {
                            StateID = 4L,
                            CountryID = 2L,
                            StateName = "Texas"
                        },
                        new
                        {
                            StateID = 5L,
                            CountryID = 3L,
                            StateName = "Hokkaido"
                        },
                        new
                        {
                            StateID = 6L,
                            CountryID = 3L,
                            StateName = "Shikoku"
                        });
                });

            modelBuilder.Entity("DependentDropDownEX.Models.City", b =>
                {
                    b.HasOne("DependentDropDownEX.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("DependentDropDownEX.Models.State", b =>
                {
                    b.HasOne("DependentDropDownEX.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("DependentDropDownEX.Models.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("DependentDropDownEX.Models.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}