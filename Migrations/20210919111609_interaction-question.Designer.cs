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
    [Migration("20210919111609_interaction-question")]
    partial class interactionquestion
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

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Choice", b =>
                {
                    b.Property<int>("ChoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MultiChoiceQuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ChoiceId");

                    b.HasIndex("MultiChoiceQuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choice");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AssignmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("QuestionId");

                    b.ToTable("Question");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Question");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.EssayQuestion", b =>
                {
                    b.HasBaseType("iread_assignment_ms.DataAccess.Data.Entity.Question");

                    b.HasIndex("AssignmentId");

                    b.HasDiscriminator().HasValue("EssayQuestion");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.InteractionQuestion", b =>
                {
                    b.HasBaseType("iread_assignment_ms.DataAccess.Data.Entity.Question");

                    b.HasIndex("AssignmentId");

                    b.HasDiscriminator().HasValue("InteractionQuestion");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.MultiChoice", b =>
                {
                    b.HasBaseType("iread_assignment_ms.DataAccess.Data.Entity.Question");

                    b.Property<int?>("RightChoiceId")
                        .HasColumnType("int");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("RightChoiceId");

                    b.HasDiscriminator().HasValue("MultiChoice");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentStatus", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany("AssignmentStatuses")
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

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Choice", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.MultiChoice", null)
                        .WithMany("Choices")
                        .HasForeignKey("MultiChoiceQuestionId");

                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Question", "MultiChoice")
                        .WithMany()
                        .HasForeignKey("QuestionId");

                    b.Navigation("MultiChoice");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.EssayQuestion", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany("EssayQuestions")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.InteractionQuestion", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany()
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.MultiChoice", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany("MultiChoices")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Choice", "RightChoice")
                        .WithMany()
                        .HasForeignKey("RightChoiceId");

                    b.Navigation("Assignment");

                    b.Navigation("RightChoice");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Assignment", b =>
                {
                    b.Navigation("AssignmentStatuses");

                    b.Navigation("EssayQuestions");

                    b.Navigation("MultiChoices");

                    b.Navigation("Stories");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.MultiChoice", b =>
                {
                    b.Navigation("Choices");
                });
#pragma warning restore 612, 618
        }
    }
}
