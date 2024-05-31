﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using eRe.Infrastructure;

#nullable disable

namespace eRe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("eRe.Classroom.Classroom", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TeacherId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("eRe.Classroom.Enrollment", b =>
                {
                    b.Property<string>("ClassroomId")
                        .HasColumnType("text");

                    b.Property<string>("StudentId")
                        .HasColumnType("text");

                    b.HasKey("ClassroomId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("eRe.Classroom.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("eRe.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Detail")
                        .HasColumnType("text");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = "A"
                        },
                        new
                        {
                            Id = 2,
                            Level = "B"
                        },
                        new
                        {
                            Id = 3,
                            Level = "C"
                        },
                        new
                        {
                            Id = 4,
                            Level = "D"
                        },
                        new
                        {
                            Id = 5,
                            Level = "E"
                        },
                        new
                        {
                            Id = 6,
                            Level = "F"
                        });
                });

            modelBuilder.Entity("eRe.Month", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Months");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = "JANUARY"
                        },
                        new
                        {
                            Id = 2,
                            Value = "FEBRUARY"
                        },
                        new
                        {
                            Id = 3,
                            Value = "MARCH"
                        },
                        new
                        {
                            Id = 4,
                            Value = "APRIL"
                        },
                        new
                        {
                            Id = 5,
                            Value = "MAY"
                        },
                        new
                        {
                            Id = 6,
                            Value = "JUNE"
                        },
                        new
                        {
                            Id = 7,
                            Value = "JULY"
                        },
                        new
                        {
                            Id = 8,
                            Value = "ARGUST"
                        },
                        new
                        {
                            Id = 9,
                            Value = "SEPTEMBER"
                        },
                        new
                        {
                            Id = 10,
                            Value = "OCTOBER"
                        },
                        new
                        {
                            Id = 11,
                            Value = "NOVEMBER"
                        },
                        new
                        {
                            Id = 12,
                            Value = "DECEMBER"
                        });
                });

            modelBuilder.Entity("eRe.Report", b =>
                {
                    b.Property<string>("ReportId")
                        .HasColumnType("text");

                    b.Property<int>("Absence")
                        .HasColumnType("integer");

                    b.Property<bool>("Accepted")
                        .HasColumnType("boolean");

                    b.Property<float>("Average")
                        .HasColumnType("real");

                    b.Property<string>("ClassroomId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsSent")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("IssuedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Month")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OverallGrade")
                        .HasColumnType("integer");

                    b.Property<string>("ParentCmt")
                        .HasColumnType("text");

                    b.Property<int>("Permission")
                        .HasColumnType("integer");

                    b.Property<int>("Ranking")
                        .HasColumnType("integer");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TeacherCmt")
                        .HasColumnType("text");

                    b.Property<float>("TotalScore")
                        .HasColumnType("real");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ReportId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("StudentId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("eRe.ReportItem", b =>
                {
                    b.Property<Guid>("ReportItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("GradeId")
                        .HasColumnType("integer");

                    b.Property<string>("ReportId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("SubjectItemId")
                        .HasColumnType("integer");

                    b.HasKey("ReportItemId");

                    b.HasIndex("ReportId");

                    b.HasIndex("SubjectItemId");

                    b.ToTable("ReportItems");
                });

            modelBuilder.Entity("eRe.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "MATH"
                        },
                        new
                        {
                            Id = 2,
                            Name = "KHMER"
                        },
                        new
                        {
                            Id = 3,
                            Name = "HISTORY"
                        },
                        new
                        {
                            Id = 4,
                            Name = "BIOLOGY"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PHYSIC"
                        },
                        new
                        {
                            Id = 6,
                            Name = "CHEMISTRY"
                        },
                        new
                        {
                            Id = 7,
                            Name = "ENGLISH"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ECONOMY"
                        },
                        new
                        {
                            Id = 9,
                            Name = "GEOGRAPHY"
                        });
                });

            modelBuilder.Entity("eRe.SubjectItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassroomId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("MaxScore")
                        .HasColumnType("real");

                    b.Property<float>("PassingScore")
                        .HasColumnType("real");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasAlternateKey("SubjectId", "ClassroomId");

                    b.HasIndex("ClassroomId");

                    b.ToTable("SubjectItems");
                });

            modelBuilder.Entity("eRe.User.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            role = "STUDENT"
                        },
                        new
                        {
                            Id = 2,
                            role = "TEACHER"
                        });
                });

            modelBuilder.Entity("eRe.User.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OtherContact")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eRe.Classroom.Enrollment", b =>
                {
                    b.HasOne("eRe.Classroom.Classroom", null)
                        .WithMany()
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eRe.Classroom.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eRe.Report", b =>
                {
                    b.HasOne("eRe.Classroom.Classroom", "Classroom")
                        .WithMany("Reports")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eRe.Classroom.Student", "Student")
                        .WithMany("Reports")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("eRe.ReportItem", b =>
                {
                    b.HasOne("eRe.Report", "Report")
                        .WithMany("ReportItems")
                        .HasForeignKey("ReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eRe.SubjectItem", "SubjectItem")
                        .WithMany("ReportItems")
                        .HasForeignKey("SubjectItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Report");

                    b.Navigation("SubjectItem");
                });

            modelBuilder.Entity("eRe.SubjectItem", b =>
                {
                    b.HasOne("eRe.Classroom.Classroom", "Classroom")
                        .WithMany("SubjectItems")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eRe.Subject", "Subject")
                        .WithMany("SubjectItems")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("eRe.Classroom.Classroom", b =>
                {
                    b.Navigation("Reports");

                    b.Navigation("SubjectItems");
                });

            modelBuilder.Entity("eRe.Classroom.Student", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("eRe.Report", b =>
                {
                    b.Navigation("ReportItems");
                });

            modelBuilder.Entity("eRe.Subject", b =>
                {
                    b.Navigation("SubjectItems");
                });

            modelBuilder.Entity("eRe.SubjectItem", b =>
                {
                    b.Navigation("ReportItems");
                });
#pragma warning restore 612, 618
        }
    }
}
