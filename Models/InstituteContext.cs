using Microsoft.EntityFrameworkCore;
using static Institute_Management.Models.CourseModule;
using static Institute_Management.Models.TeacherModule;

namespace Institute_Management.Models
{
    public class InstituteContext : DbContext
    {
        public InstituteContext(DbContextOptions<InstituteContext> options) : base(options) { }

        public DbSet<UserModule.User> Users { get; set; }
        public DbSet<StudentModule.Student> Students { get; set; }
        public DbSet<TeacherModule.Teacher> Teachers { get; set; }
        public DbSet<AdminModule.Admin> Admins { get; set; }
        public DbSet<BatchModule.Batch> Batches { get; set; }
        public DbSet<CourseModule.Course> Courses { get; set; }
        public DbSet<StudentCourseModule.StudentCourse> StudentCourses { get; set; }
        public object Contacts { get; internal set; }
        public DbSet<ContactUs> Contactus { get; set; }
        public DbSet<EnrollrequestModule> Enrollrequest {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BatchModule.Batch>().HasData();
            //modelBuilder.Entity<AdminModule.Admin>().HasData(); // This clears out data from Admin table
            //modelBuilder.Entity<StudentModule.Student>().HasData();
            //modelBuilder.Entity<Teacher>().HasData(); // This clears out data from Teacher table
            //modelBuilder.Entity<Course>().HasData();  // This clears out data from Course table
            //modelBuilder.Entity<StudentCourseModule.StudentCourse>().HasData();
            //modelBuilder.Entity<UserModule.User>().HasData();

            modelBuilder.Entity<StudentCourseModule.StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourseModule.StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StudentCourseModule.StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(sc => sc.CourseId)
                .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<Teacher>()
           .HasMany(t => t.Courses)
           .WithOne(c => c.Teacher)
           .HasForeignKey(c => c.TeacherId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CourseModule.Course>()
            .HasOne(c => c.Teacher)
            .WithMany(t => t.Courses)
            .HasForeignKey(c => c.TeacherId)
            .OnDelete(DeleteBehavior.Cascade);


            // Configure composite primary key for StudentCourse
            //modelBuilder.Entity<StudentCourseModule.StudentCourse>()
            //    .HasKey(sc => new { sc.StudentId, sc.CourseId });

            // Seed data
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seeding Users
            modelBuilder.Entity<UserModule.User>().HasData(
                new UserModule.User { UserId = 1, Name = "Admin User", Email = "admin@gmail.com", Password = "admin123", Role = "Admin", ContactDetails = "1234567890" },
                new UserModule.User { UserId = 2, Name = "John Doe", Email = "john.doe@gmail.com", Password = "password123", Role = "Student", ContactDetails = "9876543210" },
                new UserModule.User { UserId = 3, Name = "Jane Smith", Email = "jane.smith@gmail.com", Password = "teacher123", Role = "Teacher", ContactDetails = "5554443333" },
                new UserModule.User { UserId = 4, Name = "Mark Johnson", Email = "mark.johnson@gmail.com", Password = "teacher456", Role = "Teacher", ContactDetails = "6667778888" },
                new UserModule.User { UserId = 5, Name = "Alice Brown", Email = "alice.brown@gmail.com", Password = "student123", Role = "Student", ContactDetails = "9990001111" },
                new UserModule.User { UserId = 6, Name = "Tom Hanks", Email = "tom.hanks@gmail.com", Password = "student456", Role = "Student", ContactDetails = "2345678901" },
                new UserModule.User { UserId = 7, Name = "Emma Watson", Email = "emma.watson@gmail.com", Password = "student789", Role = "Student", ContactDetails = "3456789012" },
                new UserModule.User { UserId = 8, Name = "Robert Downey", Email = "robert.downey@gmail.com", Password = "teacher789", Role = "Teacher", ContactDetails = "4567890123" }
            );

            // Seeding Admin
            modelBuilder.Entity<AdminModule.Admin>().HasData(
                new AdminModule.Admin { AdminId = 1, UserId = 1 }
            );

            // Seeding Teachers
            modelBuilder.Entity<TeacherModule.Teacher>().HasData(
                new TeacherModule.Teacher { TeacherId = 1, UserId = 3, SubjectSpecialization = "Fullstack Development with .NET" },  // Teaches .NET and Software Testing
                new TeacherModule.Teacher { TeacherId = 2, UserId = 4, SubjectSpecialization = "DevOps" }, // Teaches Python, DevOps, and Data Analysis
                new TeacherModule.Teacher { TeacherId = 3, UserId = 8, SubjectSpecialization = "Cyber Security" } // Teaches React, Cyber Security, and Power BI
            );

            // Seeding Courses 
            modelBuilder.Entity<CourseModule.Course>().HasData(
                new CourseModule.Course { CourseId = 1, CourseName = "Fullstack Development with .NET", Description = "Learn to build modern full-stack applications using .NET.", TeacherId = 1 },
                new CourseModule.Course { CourseId = 2, CourseName = "Fullstack Development with Python", Description = "Master full-stack development with Python and related frameworks.", TeacherId = 2 },
                new CourseModule.Course { CourseId = 3, CourseName = "Frontend Development with React", Description = "Learn to build dynamic UIs using React.", TeacherId = 3 },
                new CourseModule.Course { CourseId = 4, CourseName = "Software Testing", Description = "Understand the principles and practices of software testing.", TeacherId = 1 },
                new CourseModule.Course { CourseId = 5, CourseName = "DevOps", Description = "Learn to automate the software delivery pipeline with DevOps practices.", TeacherId = 2 },
                new CourseModule.Course { CourseId = 6, CourseName = "Salesforce", Description = "Learn how to develop on the Salesforce platform.", TeacherId = 3 },
                new CourseModule.Course { CourseId = 7, CourseName = "Cloud Computing", Description = "Understand cloud computing principles and how to work with cloud providers.", TeacherId = 1 },
                new CourseModule.Course { CourseId = 8, CourseName = "Data Analyst", Description = "Master the techniques of data analysis using Python and Excel.", TeacherId = 2 },
                new CourseModule.Course { CourseId = 9, CourseName = "Cyber Security", Description = "Learn how to secure applications and networks from cyber threats.", TeacherId = 3 },
                new CourseModule.Course { CourseId = 10, CourseName = "Android Development", Description = "Develop mobile applications for Android using Java and Kotlin.", TeacherId = 1 },
                new CourseModule.Course { CourseId = 11, CourseName = "Artificial Intelligence", Description = "Dive into AI concepts and build intelligent systems with Python.", TeacherId = 2 },
                new CourseModule.Course { CourseId = 12, CourseName = "Power BI", Description = "Learn how to visualize and analyze data using Power BI.", TeacherId = 3 }
            );


            // Seeding Batches
            modelBuilder.Entity<BatchModule.Batch>().HasData(
                new BatchModule.Batch { BatchId = 1, BatchName = "Batch A", BatchTiming = "8:00 AM - 9:30 AM", BatchType = "Weekdays", CourseId = 1 },
                new BatchModule.Batch { BatchId = 2, BatchName = "Batch B", BatchTiming = "10:00 AM - 11:30 AM", BatchType = "Weekdays", CourseId = 2 },
                new BatchModule.Batch { BatchId = 3, BatchName = "Batch C", BatchTiming = "12:00 PM - 1:30 PM", BatchType = "Weekdays", CourseId = 4 },
                new BatchModule.Batch { BatchId = 4, BatchName = "Batch D", BatchTiming = "2:00 PM - 3:30 PM", BatchType = "Weekdays", CourseId = 3 },
                new BatchModule.Batch { BatchId = 5, BatchName = "Batch E", BatchTiming = "4:00 PM - 5:30 PM", BatchType = "Weekdays", CourseId = 5 },
                new BatchModule.Batch { BatchId = 6, BatchName = "Batch F", BatchTiming = "6:00 PM - 7:30 PM", BatchType = "Weekdays", CourseId = 6 },
                new BatchModule.Batch { BatchId = 7, BatchName = "Batch G", BatchTiming = "8:00 AM - 9:30 AM", BatchType = "Weekend", CourseId = 7 },
                new BatchModule.Batch { BatchId = 8, BatchName = "Batch H", BatchTiming = "10:00 AM - 11:30 AM", BatchType = "Weekend", CourseId = 8 },
                new BatchModule.Batch { BatchId = 9, BatchName = "Batch I", BatchTiming = "12:00 PM - 1:30 PM", BatchType = "Weekend", CourseId = 9 },
                new BatchModule.Batch { BatchId = 10, BatchName = "Batch J", BatchTiming = "2:00 PM - 3:30 PM", BatchType = "Weekend", CourseId = 10 },
                new BatchModule.Batch { BatchId = 11, BatchName = "Batch K", BatchTiming = "4:00 PM - 5:30 PM", BatchType = "Weekend", CourseId = 11 },
                new BatchModule.Batch { BatchId = 12, BatchName = "Batch L", BatchTiming = "6:00 PM - 7:30 PM", BatchType = "Weekend", CourseId = 12 }
            );

            // Seeding Students and linking them to Batches
            modelBuilder.Entity<StudentModule.Student>().HasData(
                new StudentModule.Student { StudentId = 1, UserId = 2, BatchId = 1 },
                new StudentModule.Student { StudentId = 2, UserId = 5, BatchId = 2 },
                new StudentModule.Student { StudentId = 3, UserId = 6, BatchId = 3 },
                new StudentModule.Student { StudentId = 4, UserId = 7, BatchId = 4 },
                new StudentModule.Student { StudentId = 5, UserId = 8, BatchId = 5 }
            );

            // Seeding Student-Course Enrollments
            modelBuilder.Entity<StudentCourseModule.StudentCourse>().HasData(
                new StudentCourseModule.StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourseModule.StudentCourse { StudentId = 2, CourseId = 2 },
                new StudentCourseModule.StudentCourse { StudentId = 3, CourseId = 4 },
                new StudentCourseModule.StudentCourse { StudentId = 4, CourseId = 3 },
                new StudentCourseModule.StudentCourse { StudentId = 5, CourseId = 5 }
            );
        }


    }
}