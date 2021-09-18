﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iread_assignment_ms.DataAccess.Data;

namespace iread_assignment_ms.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210918124317_addStoryIdField")]
    partial class addStoryIdField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClassId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("TeacherFirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TeacherId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TeacherLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AssignmentId");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentStatus", b =>
                {
                    b.Property<int>("AssignmentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AssignmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("StudentFirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentId")
                        .HasColumnType("text");

                    b.Property<string>("StudentLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AssignmentStatusId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("AssignmentStatus");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentStory", b =>
                {
                    b.Property<int>("AssignmentStoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AssignmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("StoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("StoryTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AssignmentStoryId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("AssignmentStory");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentStatus", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany("AssignmentStudents")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentStory", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany("Stories")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Assignment", b =>
                {
                    b.Navigation("AssignmentStudents");

                    b.Navigation("Stories");
                });
#pragma warning restore 612, 618
        }
    }
}
