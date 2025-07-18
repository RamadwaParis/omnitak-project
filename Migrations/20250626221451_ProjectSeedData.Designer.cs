﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OmintakProduction.Data;

#nullable disable

namespace OmintakProduction.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250626221451_ProjectSeedData")]
    partial class ProjectSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OmintakProduction.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DueDate")
                        .HasColumnType("date");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 4,
                            Description = "This is a sample ticket description.",
                            DueDate = new DateOnly(2025, 6, 26),
                            ProjectName = "Sample Ticket",
                            Status = "Done"
                        });
                });

            modelBuilder.Entity("OmintakProduction.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AssignedToUserId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("CompletedAt")
                        .HasColumnType("date");

                    b.Property<DateOnly>("CreatedAt")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DueDate")
                        .HasColumnType("date");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ticket");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompletedAt = new DateOnly(2025, 6, 26),
                            CreatedAt = new DateOnly(2025, 6, 26),
                            Description = "This is a sample ticket description.",
                            DueDate = new DateOnly(2025, 6, 26),
                            Status = "ToDo",
                            Title = "Sample Ticket"
                        },
                        new
                        {
                            Id = 2,
                            CompletedAt = new DateOnly(2025, 6, 26),
                            CreatedAt = new DateOnly(2025, 6, 26),
                            Description = "This is a sample ticket description.",
                            DueDate = new DateOnly(2025, 6, 26),
                            Status = "In_Progress",
                            Title = "Sample Ticket"
                        },
                        new
                        {
                            Id = 3,
                            CompletedAt = new DateOnly(2025, 6, 26),
                            CreatedAt = new DateOnly(2025, 6, 26),
                            Description = "This is a sample ticket description.",
                            DueDate = new DateOnly(2025, 6, 26),
                            Status = "In_Review",
                            Title = "Sample Ticket"
                        },
                        new
                        {
                            Id = 4,
                            CompletedAt = new DateOnly(2025, 6, 26),
                            CreatedAt = new DateOnly(2025, 6, 26),
                            Description = "This is a sample ticket description.",
                            DueDate = new DateOnly(2025, 6, 26),
                            Status = "Done",
                            Title = "Sample Ticket"
                        });
                });

            modelBuilder.Entity("OmintakProduction.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateOnly>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedDate = new DateOnly(2025, 6, 26),
                            Email = "Admin@omnitak.com",
                            Password = "Admin@123",
                            RoleId = "1",
                            Status = "Active",
                            UserName = "AdminUser"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedDate = new DateOnly(2025, 6, 26),
                            Email = "Engineer@omnitak.com",
                            Password = "Engineer@123",
                            RoleId = "2",
                            Status = "Active",
                            UserName = "EngineerUser"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedDate = new DateOnly(2025, 6, 26),
                            Email = "Tester@omnitak.com",
                            Password = "Tester@123",
                            RoleId = "3",
                            Status = "Active",
                            UserName = "TesterUser"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
