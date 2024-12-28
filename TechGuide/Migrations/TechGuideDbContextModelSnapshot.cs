﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechGuide.Models;

#nullable disable

namespace TechGuide.Migrations
{
    [DbContext(typeof(TechGuideDbContext))]
    partial class TechGuideDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechGuide.Models.AuditLogs", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogID"));

                    b.Property<string>("Operation")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TableName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("LogID");

                    b.HasIndex("UserID");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("TechGuide.Models.Chapters", b =>
                {
                    b.Property<int>("ChapterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChapterID"));

                    b.Property<string>("ChapterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChapterVideo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ChapterID");

                    b.ToTable("Chapters");
                });

            modelBuilder.Entity("TechGuide.Models.Configurations", b =>
                {
                    b.Property<int>("ConfigID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConfigID"));

                    b.Property<string>("ConfigKey")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConfigValue")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.HasKey("ConfigID");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("TechGuide.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("CourseName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SemesterID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("SemesterID");

                    b.HasIndex("TypeID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TechGuide.Models.CoursePrerequisites", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("PrerequisiteID")
                        .HasColumnType("int");

                    b.HasKey("CourseID", "PrerequisiteID");

                    b.HasIndex("PrerequisiteID");

                    b.ToTable("CoursePrerequisites");
                });

            modelBuilder.Entity("TechGuide.Models.Department", b =>
                {
                    b.Property<int>("DepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepID"));

                    b.Property<string>("DepName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SubCode")
                        .HasColumnType("int");

                    b.HasKey("DepID");

                    b.HasIndex("SubCode");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("TechGuide.Models.ErrorLogs", b =>
                {
                    b.Property<int>("ErrorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ErrorID"));

                    b.Property<DateTime>("ErrorDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ErrorMessage")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ErrorID");

                    b.HasIndex("UserID");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("TechGuide.Models.Semester", b =>
                {
                    b.Property<int>("SemesterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemesterID"));

                    b.Property<int>("DepID")
                        .HasMaxLength(40)
                        .HasColumnType("int");

                    b.Property<string>("SemesterName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SemesterID");

                    b.HasIndex("DepID");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("TechGuide.Models.Subjects", b =>
                {
                    b.Property<int>("SubCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCode"));

                    b.Property<int>("ChapterID")
                        .HasColumnType("int");

                    b.Property<string>("SubName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubCode");

                    b.HasIndex("ChapterID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("TechGuide.Models.Types", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeID"));

                    b.Property<string>("TypeName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TypeID");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("TechGuide.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("Role")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TechGuide.Models.AuditLogs", b =>
                {
                    b.HasOne("TechGuide.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TechGuide.Models.Course", b =>
                {
                    b.HasOne("TechGuide.Models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("SemesterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechGuide.Models.Types", "Types")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");

                    b.Navigation("Types");
                });

            modelBuilder.Entity("TechGuide.Models.CoursePrerequisites", b =>
                {
                    b.HasOne("TechGuide.Models.Course", "course")
                        .WithMany("CoursePrerequisites")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechGuide.Models.Course", "Prerequisite")
                        .WithMany()
                        .HasForeignKey("PrerequisiteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Prerequisite");

                    b.Navigation("course");
                });

            modelBuilder.Entity("TechGuide.Models.Department", b =>
                {
                    b.HasOne("TechGuide.Models.Subjects", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("TechGuide.Models.ErrorLogs", b =>
                {
                    b.HasOne("TechGuide.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("TechGuide.Models.Semester", b =>
                {
                    b.HasOne("TechGuide.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("TechGuide.Models.Subjects", b =>
                {
                    b.HasOne("TechGuide.Models.Chapters", "Chapters")
                        .WithMany()
                        .HasForeignKey("ChapterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chapters");
                });

            modelBuilder.Entity("TechGuide.Models.Course", b =>
                {
                    b.Navigation("CoursePrerequisites");
                });
#pragma warning restore 612, 618
        }
    }
}
