﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UrashimaServer.Database;

#nullable disable

namespace UrashimaServer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240107055620_UrashimaDB_v4_AddRealTimeModels")]
    partial class UrashimaDB_v4_AddRealTimeModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UrashimaServer.Database.Models.AdsCreationRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdsContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdsPointId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdsCreationRequests");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.AdsFormType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdsFormTypes");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.AdsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdsTypes");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.BoardModify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdsBoardId")
                        .HasColumnType("int");

                    b.Property<int>("AdsPointId")
                        .HasColumnType("int");

                    b.Property<string>("AdsType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdsPointId");

                    b.ToTable("BoardModifies");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.Connection", b =>
                {
                    b.Property<string>("ConnectionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Connected")
                        .HasColumnType("bit");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ConnectionId");

                    b.HasIndex("UserEmail");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.LocationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocationTypes");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.PointModify", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdsForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdsPointId")
                        .HasColumnType("int");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Planned")
                        .HasColumnType("bit");

                    b.Property<string>("Reasons")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PointModifies");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.PointModifyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdsPointId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdsPointId");

                    b.ToTable("PointModifyImages");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.ReportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReportTypes");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.WardDistrict", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WardDistricts");
                });

            modelBuilder.Entity("UrashimaServer.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordResetToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TokenCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnitUnderManagement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdsCreateRequestId")
                        .HasColumnType("int");

                    b.Property<int>("AdsPointId")
                        .HasColumnType("int");

                    b.Property<string>("AdsType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdsCreateRequestId")
                        .IsUnique()
                        .HasFilter("[AdsCreateRequestId] IS NOT NULL");

                    b.HasIndex("AdsPointId");

                    b.ToTable("AdsBoards");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdsCreateRequestId")
                        .HasColumnType("int");

                    b.Property<string>("AdsForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<bool>("Planned")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AdsCreateRequestId")
                        .IsUnique()
                        .HasFilter("[AdsCreateRequestId] IS NOT NULL");

                    b.ToTable("AdsPoints");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsPointImage", b =>
                {
                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AdsPointId")
                        .HasColumnType("int");

                    b.HasKey("Image");

                    b.HasIndex("AdsPointId");

                    b.ToTable("AdsPointImages");
                });

            modelBuilder.Entity("UrashimaServer.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AdsBoardId")
                        .HasColumnType("int");

                    b.Property<int?>("AdsPointId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ReportStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ReportType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TreatmentProcess")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdsBoardId");

                    b.HasIndex("AdsPointId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("UrashimaServer.Models.ReportImage", b =>
                {
                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.HasKey("Image");

                    b.HasIndex("ReportId");

                    b.ToTable("ReportImages");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.BoardModify", b =>
                {
                    b.HasOne("UrashimaServer.Database.Models.PointModify", "AdsPoint")
                        .WithMany("AdsBoard")
                        .HasForeignKey("AdsPointId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AdsPoint");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.Connection", b =>
                {
                    b.HasOne("UrashimaServer.Database.Models.User", null)
                        .WithMany("Connections")
                        .HasForeignKey("UserEmail");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.PointModifyImage", b =>
                {
                    b.HasOne("UrashimaServer.Database.Models.PointModify", "AdsPoint")
                        .WithMany("Images")
                        .HasForeignKey("AdsPointId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AdsPoint");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsBoard", b =>
                {
                    b.HasOne("UrashimaServer.Database.Models.AdsCreationRequest", "AdsCreateRequest")
                        .WithOne("AdsBoard")
                        .HasForeignKey("UrashimaServer.Models.AdsBoard", "AdsCreateRequestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrashimaServer.Models.AdsPoint", "AdsPoint")
                        .WithMany("AdsBoard")
                        .HasForeignKey("AdsPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdsCreateRequest");

                    b.Navigation("AdsPoint");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsPoint", b =>
                {
                    b.HasOne("UrashimaServer.Database.Models.AdsCreationRequest", "AdsCreateRequest")
                        .WithOne("AdsPoint")
                        .HasForeignKey("UrashimaServer.Models.AdsPoint", "AdsCreateRequestId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("AdsCreateRequest");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsPointImage", b =>
                {
                    b.HasOne("UrashimaServer.Models.AdsPoint", "AdsPoint")
                        .WithMany("Images")
                        .HasForeignKey("AdsPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdsPoint");
                });

            modelBuilder.Entity("UrashimaServer.Models.Report", b =>
                {
                    b.HasOne("UrashimaServer.Models.AdsBoard", "AdsBoard")
                        .WithMany("Reports")
                        .HasForeignKey("AdsBoardId");

                    b.HasOne("UrashimaServer.Models.AdsPoint", "AdsPoint")
                        .WithMany("Reports")
                        .HasForeignKey("AdsPointId");

                    b.HasOne("UrashimaServer.Database.Models.Location", "Location")
                        .WithMany("Reports")
                        .HasForeignKey("LocationId");

                    b.Navigation("AdsBoard");

                    b.Navigation("AdsPoint");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("UrashimaServer.Models.ReportImage", b =>
                {
                    b.HasOne("UrashimaServer.Models.Report", "Report")
                        .WithMany("Images")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Report");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.AdsCreationRequest", b =>
                {
                    b.Navigation("AdsBoard");

                    b.Navigation("AdsPoint");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.Location", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.PointModify", b =>
                {
                    b.Navigation("AdsBoard");

                    b.Navigation("Images");
                });

            modelBuilder.Entity("UrashimaServer.Database.Models.User", b =>
                {
                    b.Navigation("Connections");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsBoard", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("UrashimaServer.Models.AdsPoint", b =>
                {
                    b.Navigation("AdsBoard");

                    b.Navigation("Images");

                    b.Navigation("Reports");
                });

            modelBuilder.Entity("UrashimaServer.Models.Report", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
