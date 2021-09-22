﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iread_assignment_ms.DataAccess.Data;

namespace iread_assignment_ms.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAnswered")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("StudentFirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentId")
                        .HasColumnType("text");

                    b.Property<string>("StudentLastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Answer");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AnswerInteraction", b =>
                {
                    b.Property<int>("AnswerInteractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("InteractionAnswerId")
                        .HasColumnType("int");

                    b.Property<int?>("InteractionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerInteractionId");

                    b.HasIndex("InteractionAnswerId");

                    b.ToTable("AnswerInteraction");
                });

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

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentAttachment", b =>
                {
                    b.Property<int>("AssignmentAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<int>("AttachmentId")
                        .HasColumnType("int");

                    b.HasKey("AssignmentAttachmentId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("AssignmentAttachments");
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

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.EssayAnswer", b =>
                {
                    b.HasBaseType("iread_assignment_ms.DataAccess.Data.Entity.Answer");

                    b.Property<int?>("EssayQuestionQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasIndex("EssayQuestionQuestionId");

                    b.HasDiscriminator().HasValue("EssayAnswer");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.InteractionAnswer", b =>
                {
                    b.HasBaseType("iread_assignment_ms.DataAccess.Data.Entity.Answer");

                    b.Property<int?>("InteractionQuestionQuestionId")
                        .HasColumnType("int");

                    b.HasIndex("InteractionQuestionQuestionId");

                    b.HasDiscriminator().HasValue("InteractionAnswer");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.MultiChoiceAnswer", b =>
                {
                    b.HasBaseType("iread_assignment_ms.DataAccess.Data.Entity.Answer");

                    b.Property<int?>("ChosenChoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("MultiChoiceQuestionId")
                        .HasColumnType("int");

                    b.HasIndex("ChosenChoiceId");

                    b.HasIndex("MultiChoiceQuestionId");

                    b.HasDiscriminator().HasValue("MultiChoiceAnswer");
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

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.Answer", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AnswerInteraction", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.InteractionAnswer", "InteractionAnswer")
                        .WithMany("Interactions")
                        .HasForeignKey("InteractionAnswerId");

                    b.Navigation("InteractionAnswer");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.AssignmentAttachment", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Assignment", "Assignment")
                        .WithMany("Attachments")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");
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

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.EssayAnswer", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.EssayQuestion", null)
                        .WithMany("EssayAnswers")
                        .HasForeignKey("EssayQuestionQuestionId");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.InteractionAnswer", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.InteractionQuestion", null)
                        .WithMany("InteractionAnswers")
                        .HasForeignKey("InteractionQuestionQuestionId");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.MultiChoiceAnswer", b =>
                {
                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.Choice", "ChosenChoice")
                        .WithMany()
                        .HasForeignKey("ChosenChoiceId");

                    b.HasOne("iread_assignment_ms.DataAccess.Data.Entity.MultiChoice", null)
                        .WithMany("MultiChoiceAnswers")
                        .HasForeignKey("MultiChoiceQuestionId");

                    b.Navigation("ChosenChoice");
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
                        .WithMany("InteractionQuestions")
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

                    b.Navigation("Attachments");

                    b.Navigation("EssayQuestions");

                    b.Navigation("InteractionQuestions");

                    b.Navigation("MultiChoices");

                    b.Navigation("Stories");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.InteractionAnswer", b =>
                {
                    b.Navigation("Interactions");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.EssayQuestion", b =>
                {
                    b.Navigation("EssayAnswers");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.InteractionQuestion", b =>
                {
                    b.Navigation("InteractionAnswers");
                });

            modelBuilder.Entity("iread_assignment_ms.DataAccess.Data.Entity.MultiChoice", b =>
                {
                    b.Navigation("Choices");

                    b.Navigation("MultiChoiceAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
