﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using studentsystem3.data;

#nullable disable

namespace studentsystem3.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240719043953_Addfirstrelation")]
    partial class Addfirstrelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("studentsystem3.course", b =>
                {
                    b.Property<int>("course_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("course_id"));

                    b.Property<string>("description")
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("enddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("startdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("student_id")
                        .HasColumnType("int");

                    b.Property<int>("student_id1")
                        .HasColumnType("int");

                    b.HasKey("course_id");

                    b.HasIndex("student_id1");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("studentsystem3.homework", b =>
                {
                    b.Property<int>("homework_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("homework_id"));

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<int>("student_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("submissiontimr")
                        .HasColumnType("datetime2");

                    b.HasKey("homework_id");

                    b.ToTable("homeworks");
                });

            modelBuilder.Entity("studentsystem3.resources", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.HasKey("id");

                    b.ToTable("resourcess");
                });

            modelBuilder.Entity("studentsystem3.student", b =>
                {
                    b.Property<int>("student_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("student_id"));

                    b.Property<DateTime?>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("phonenumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("registeredon")
                        .HasColumnType("datetime2");

                    b.HasKey("student_id");

                    b.ToTable("studnts");
                });

            modelBuilder.Entity("studentsystem3.studentcorse", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("course_id")
                        .HasColumnType("int");

                    b.Property<int>("ststudent_id")
                        .HasColumnType("int");

                    b.HasKey("name");

                    b.ToTable("studentcourses");
                });

            modelBuilder.Entity("studentsystem3.course", b =>
                {
                    b.HasOne("studentsystem3.student", "student")
                        .WithMany("courses")
                        .HasForeignKey("student_id1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("student");
                });

            modelBuilder.Entity("studentsystem3.student", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}
