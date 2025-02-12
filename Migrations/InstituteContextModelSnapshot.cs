﻿// <auto-generated />
using Institute_Management.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Institute_Management.Migrations
{
    [DbContext(typeof(InstituteContext))]
    partial class InstituteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Institute_Management.Models.AdminModule+Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            AdminId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.BatchModule+Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BatchId"));

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatchTiming")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BatchType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("BatchId");

                    b.HasIndex("CourseId");

                    b.ToTable("Batches");

                    b.HasData(
                        new
                        {
                            BatchId = 1,
                            BatchName = "Batch A",
                            BatchTiming = "8:00 AM - 9:30 AM",
                            BatchType = "Weekdays",
                            CourseId = 1
                        },
                        new
                        {
                            BatchId = 2,
                            BatchName = "Batch B",
                            BatchTiming = "10:00 AM - 11:30 AM",
                            BatchType = "Weekdays",
                            CourseId = 2
                        },
                        new
                        {
                            BatchId = 3,
                            BatchName = "Batch C",
                            BatchTiming = "12:00 PM - 1:30 PM",
                            BatchType = "Weekdays",
                            CourseId = 4
                        },
                        new
                        {
                            BatchId = 4,
                            BatchName = "Batch D",
                            BatchTiming = "2:00 PM - 3:30 PM",
                            BatchType = "Weekdays",
                            CourseId = 3
                        },
                        new
                        {
                            BatchId = 5,
                            BatchName = "Batch E",
                            BatchTiming = "4:00 PM - 5:30 PM",
                            BatchType = "Weekdays",
                            CourseId = 5
                        },
                        new
                        {
                            BatchId = 6,
                            BatchName = "Batch F",
                            BatchTiming = "6:00 PM - 7:30 PM",
                            BatchType = "Weekdays",
                            CourseId = 6
                        },
                        new
                        {
                            BatchId = 7,
                            BatchName = "Batch G",
                            BatchTiming = "8:00 AM - 9:30 AM",
                            BatchType = "Weekend",
                            CourseId = 7
                        },
                        new
                        {
                            BatchId = 8,
                            BatchName = "Batch H",
                            BatchTiming = "10:00 AM - 11:30 AM",
                            BatchType = "Weekend",
                            CourseId = 8
                        },
                        new
                        {
                            BatchId = 9,
                            BatchName = "Batch I",
                            BatchTiming = "12:00 PM - 1:30 PM",
                            BatchType = "Weekend",
                            CourseId = 9
                        },
                        new
                        {
                            BatchId = 10,
                            BatchName = "Batch J",
                            BatchTiming = "2:00 PM - 3:30 PM",
                            BatchType = "Weekend",
                            CourseId = 10
                        },
                        new
                        {
                            BatchId = 11,
                            BatchName = "Batch K",
                            BatchTiming = "4:00 PM - 5:30 PM",
                            BatchType = "Weekend",
                            CourseId = 11
                        },
                        new
                        {
                            BatchId = 12,
                            BatchName = "Batch L",
                            BatchTiming = "6:00 PM - 7:30 PM",
                            BatchType = "Weekend",
                            CourseId = 12
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.ContactUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contactus");
                });

            modelBuilder.Entity("Institute_Management.Models.CourseModule+Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int?>("BatchId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("BatchId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Fullstack Development with .NET",
                            Description = "Learn to build modern full-stack applications using .NET.",
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Fullstack Development with Python",
                            Description = "Master full-stack development with Python and related frameworks.",
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "Frontend Development with React",
                            Description = "Learn to build dynamic UIs using React.",
                            TeacherId = 3
                        },
                        new
                        {
                            CourseId = 4,
                            CourseName = "Software Testing",
                            Description = "Understand the principles and practices of software testing.",
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 5,
                            CourseName = "DevOps",
                            Description = "Learn to automate the software delivery pipeline with DevOps practices.",
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 6,
                            CourseName = "Salesforce",
                            Description = "Learn how to develop on the Salesforce platform.",
                            TeacherId = 3
                        },
                        new
                        {
                            CourseId = 7,
                            CourseName = "Cloud Computing",
                            Description = "Understand cloud computing principles and how to work with cloud providers.",
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 8,
                            CourseName = "Data Analyst",
                            Description = "Master the techniques of data analysis using Python and Excel.",
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 9,
                            CourseName = "Cyber Security",
                            Description = "Learn how to secure applications and networks from cyber threats.",
                            TeacherId = 3
                        },
                        new
                        {
                            CourseId = 10,
                            CourseName = "Android Development",
                            Description = "Develop mobile applications for Android using Java and Kotlin.",
                            TeacherId = 1
                        },
                        new
                        {
                            CourseId = 11,
                            CourseName = "Artificial Intelligence",
                            Description = "Dive into AI concepts and build intelligent systems with Python.",
                            TeacherId = 2
                        },
                        new
                        {
                            CourseId = 12,
                            CourseName = "Power BI",
                            Description = "Learn how to visualize and analyze data using Power BI.",
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.EnrollrequestModule", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Enrollrequest");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentCourseModule+StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 4
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 5
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.StudentModule+Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int?>("BatchId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("BatchId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            BatchId = 1,
                            UserId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            BatchId = 2,
                            UserId = 5
                        },
                        new
                        {
                            StudentId = 3,
                            BatchId = 3,
                            UserId = 6
                        },
                        new
                        {
                            StudentId = 4,
                            BatchId = 4,
                            UserId = 7
                        },
                        new
                        {
                            StudentId = 5,
                            BatchId = 5,
                            UserId = 8
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.TeacherModule+Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("SubjectSpecialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            SubjectSpecialization = "Fullstack Development with .NET",
                            UserId = 3
                        },
                        new
                        {
                            TeacherId = 2,
                            SubjectSpecialization = "DevOps",
                            UserId = 4
                        },
                        new
                        {
                            TeacherId = 3,
                            SubjectSpecialization = "Cyber Security",
                            UserId = 8
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.UserModule+User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("ContactDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ContactDetails = "1234567890",
                            Email = "admin@gmail.com",
                            Name = "Admin User",
                            Password = "admin123",
                            Role = "Admin"
                        },
                        new
                        {
                            UserId = 2,
                            ContactDetails = "9876543210",
                            Email = "john.doe@gmail.com",
                            Name = "John Doe",
                            Password = "password123",
                            Role = "Student"
                        },
                        new
                        {
                            UserId = 3,
                            ContactDetails = "5554443333",
                            Email = "jane.smith@gmail.com",
                            Name = "Jane Smith",
                            Password = "teacher123",
                            Role = "Teacher"
                        },
                        new
                        {
                            UserId = 4,
                            ContactDetails = "6667778888",
                            Email = "mark.johnson@gmail.com",
                            Name = "Mark Johnson",
                            Password = "teacher456",
                            Role = "Teacher"
                        },
                        new
                        {
                            UserId = 5,
                            ContactDetails = "9990001111",
                            Email = "alice.brown@gmail.com",
                            Name = "Alice Brown",
                            Password = "student123",
                            Role = "Student"
                        },
                        new
                        {
                            UserId = 6,
                            ContactDetails = "2345678901",
                            Email = "tom.hanks@gmail.com",
                            Name = "Tom Hanks",
                            Password = "student456",
                            Role = "Student"
                        },
                        new
                        {
                            UserId = 7,
                            ContactDetails = "3456789012",
                            Email = "emma.watson@gmail.com",
                            Name = "Emma Watson",
                            Password = "student789",
                            Role = "Student"
                        },
                        new
                        {
                            UserId = 8,
                            ContactDetails = "4567890123",
                            Email = "robert.downey@gmail.com",
                            Name = "Robert Downey",
                            Password = "teacher789",
                            Role = "Teacher"
                        });
                });

            modelBuilder.Entity("Institute_Management.Models.AdminModule+Admin", b =>
                {
                    b.HasOne("Institute_Management.Models.UserModule+User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Institute_Management.Models.BatchModule+Batch", b =>
                {
                    b.HasOne("Institute_Management.Models.CourseModule+Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Institute_Management.Models.CourseModule+Course", b =>
                {
                    b.HasOne("Institute_Management.Models.BatchModule+Batch", null)
                        .WithMany("Courses")
                        .HasForeignKey("BatchId");

                    b.HasOne("Institute_Management.Models.TeacherModule+Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentCourseModule+StudentCourse", b =>
                {
                    b.HasOne("Institute_Management.Models.CourseModule+Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Institute_Management.Models.StudentModule+Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentModule+Student", b =>
                {
                    b.HasOne("Institute_Management.Models.BatchModule+Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId");

                    b.HasOne("Institute_Management.Models.UserModule+User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Batch");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Institute_Management.Models.TeacherModule+Teacher", b =>
                {
                    b.HasOne("Institute_Management.Models.UserModule+User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Institute_Management.Models.BatchModule+Batch", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Institute_Management.Models.CourseModule+Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Institute_Management.Models.StudentModule+Student", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Institute_Management.Models.TeacherModule+Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
