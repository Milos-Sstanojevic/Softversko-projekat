﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace back.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230422004106_V14")]
    partial class V14
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("QuestionID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("Models.QuCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("QuestionCategorys");
                });

            modelBuilder.Entity("Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<bool>("Pending")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("QuestionCategoryID");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Models.Quiz", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<bool>("Pending")
                        .HasColumnType("bit");

                    b.Property<bool>("QuizExist")
                        .HasColumnType("bit");

                    b.Property<int?>("QuizMakerID")
                        .HasColumnType("int");

                    b.Property<int>("TimesPlayed")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("QuizMakerID");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("Models.QuizUser", b =>
                {
                    b.Property<int>("QuizID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("QuizID", "UserID");

                    b.HasIndex("QuizID")
                        .IsUnique();

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("QuizzesUsers");
                });

            modelBuilder.Entity("Models.Score", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("QuizID")
                        .HasColumnType("int");

                    b.Property<int>("ScoreValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserIDID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("QuizID");

                    b.HasIndex("UserIDID");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("AccountVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Conf_num")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfQuizzesDone")
                        .HasColumnType("int");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProfilePicutre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("wantAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("wantQuizMaker")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuestionQuiz", b =>
                {
                    b.Property<int>("QuestionsID")
                        .HasColumnType("int");

                    b.Property<int>("QuizzesID")
                        .HasColumnType("int");

                    b.HasKey("QuestionsID", "QuizzesID");

                    b.HasIndex("QuizzesID");

                    b.ToTable("QuestionQuiz");
                });

            modelBuilder.Entity("Models.Answer", b =>
                {
                    b.HasOne("Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionID");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Models.Question", b =>
                {
                    b.HasOne("Models.QuCategory", "QuestionCategory")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionCategoryID");

                    b.Navigation("QuestionCategory");
                });

            modelBuilder.Entity("Models.Quiz", b =>
                {
                    b.HasOne("Models.Category", "Category")
                        .WithMany("Quizzes")
                        .HasForeignKey("CategoryID");

                    b.HasOne("Models.Users", "QuizMaker")
                        .WithMany("QuizzesMade")
                        .HasForeignKey("QuizMakerID");

                    b.Navigation("Category");

                    b.Navigation("QuizMaker");
                });

            modelBuilder.Entity("Models.QuizUser", b =>
                {
                    b.HasOne("Models.Quiz", "Quiz")
                        .WithOne("UsersPlayed")
                        .HasForeignKey("Models.QuizUser", "QuizID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Users", "User")
                        .WithOne("QuizzesDone")
                        .HasForeignKey("Models.QuizUser", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quiz");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Score", b =>
                {
                    b.HasOne("Models.Quiz", "Quiz")
                        .WithMany("Scores")
                        .HasForeignKey("QuizID");

                    b.HasOne("Models.Users", "UserID")
                        .WithMany("Scores")
                        .HasForeignKey("UserIDID");

                    b.Navigation("Quiz");

                    b.Navigation("UserID");
                });

            modelBuilder.Entity("QuestionQuiz", b =>
                {
                    b.HasOne("Models.Question", null)
                        .WithMany()
                        .HasForeignKey("QuestionsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Quiz", null)
                        .WithMany()
                        .HasForeignKey("QuizzesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Category", b =>
                {
                    b.Navigation("Quizzes");
                });

            modelBuilder.Entity("Models.QuCategory", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Models.Quiz", b =>
                {
                    b.Navigation("Scores");

                    b.Navigation("UsersPlayed");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.Navigation("QuizzesDone");

                    b.Navigation("QuizzesMade");

                    b.Navigation("Scores");
                });
#pragma warning restore 612, 618
        }
    }
}
