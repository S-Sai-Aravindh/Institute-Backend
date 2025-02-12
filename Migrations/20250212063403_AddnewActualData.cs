using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Institute_Management.Migrations
{
    /// <inheritdoc />
    public partial class AddnewActualData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "BatchTiming", "BatchType" },
                values: new object[] { "8:00 AM - 9:30 AM", "Weekdays" });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "BatchTiming", "BatchType" },
                values: new object[] { "10:00 AM - 11:30 AM", "Weekdays" });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "BatchTiming", "BatchType", "CourseId" },
                values: new object[] { "12:00 PM - 1:30 PM", "Weekdays", 4 });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "BatchName", "BatchTiming", "BatchType", "CourseId" },
                values: new object[] { 4, "Batch D", "2:00 PM - 3:30 PM", "Weekdays", 3 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseName", "Description" },
                values: new object[] { "Fullstack Development with .NET", "Learn to build modern full-stack applications using .NET." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseName", "Description" },
                values: new object[] { "Fullstack Development with Python", "Master full-stack development with Python and related frameworks." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseName", "Description", "TeacherId" },
                values: new object[] { "Frontend Development with React", "Learn to build dynamic UIs using React.", 3 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "BatchId", "CourseName", "Description", "TeacherId" },
                values: new object[,]
                {
                    { 4, null, "Software Testing", "Understand the principles and practices of software testing.", 1 },
                    { 5, null, "DevOps", "Learn to automate the software delivery pipeline with DevOps practices.", 2 },
                    { 7, null, "Cloud Computing", "Understand cloud computing principles and how to work with cloud providers.", 1 },
                    { 8, null, "Data Analyst", "Master the techniques of data analysis using Python and Excel.", 2 },
                    { 10, null, "Android Development", "Develop mobile applications for Android using Java and Kotlin.", 1 },
                    { 11, null, "Artificial Intelligence", "Dive into AI concepts and build intelligent systems with Python.", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Email",
                value: "admin@gmail.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Email",
                value: "john.doe@gmail.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Email",
                value: "jane.smith@gmail.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Email",
                value: "mark.johnson@gmail.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Email",
                value: "alice.brown@gmail.com");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ContactDetails", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 6, "2345678901", "tom.hanks@gmail.com", "Tom Hanks", "student456", "Student" },
                    { 7, "3456789012", "emma.watson@gmail.com", "Emma Watson", "student789", "Student" },
                    { 8, "4567890123", "robert.downey@gmail.com", "Robert Downey", "teacher789", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "BatchName", "BatchTiming", "BatchType", "CourseId" },
                values: new object[,]
                {
                    { 5, "Batch E", "4:00 PM - 5:30 PM", "Weekdays", 5 },
                    { 7, "Batch G", "8:00 AM - 9:30 AM", "Weekend", 7 },
                    { 8, "Batch H", "10:00 AM - 11:30 AM", "Weekend", 8 },
                    { 10, "Batch J", "2:00 PM - 3:30 PM", "Weekend", 10 },
                    { 11, "Batch K", "4:00 PM - 5:30 PM", "Weekend", 11 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BatchId", "UserId" },
                values: new object[,]
                {
                    { 3, 3, 6 },
                    { 4, 4, 7 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "SubjectSpecialization", "UserId" },
                values: new object[] { 3, "Software Engineering", 8 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "BatchId", "CourseName", "Description", "TeacherId" },
                values: new object[,]
                {
                    { 6, null, "Salesforce", "Learn how to develop on the Salesforce platform.", 3 },
                    { 9, null, "Cyber Security", "Learn how to secure applications and networks from cyber threats.", 3 },
                    { 12, null, "Power BI", "Learn how to visualize and analyze data using Power BI.", 3 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 4, 3 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BatchId", "UserId" },
                values: new object[] { 5, 5, 8 });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "BatchName", "BatchTiming", "BatchType", "CourseId" },
                values: new object[,]
                {
                    { 6, "Batch F", "6:00 PM - 7:30 PM", "Weekdays", 6 },
                    { 9, "Batch I", "12:00 PM - 1:30 PM", "Weekend", 9 },
                    { 12, "Batch L", "6:00 PM - 7:30 PM", "Weekend", 12 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[] { 5, 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 1,
                columns: new[] { "BatchTiming", "BatchType" },
                values: new object[] { "9:00 AM - 12:00 PM", "Full-Time" });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 2,
                columns: new[] { "BatchTiming", "BatchType" },
                values: new object[] { "2:00 PM - 5:00 PM", "Part-Time" });

            migrationBuilder.UpdateData(
                table: "Batches",
                keyColumn: "BatchId",
                keyValue: 3,
                columns: new[] { "BatchTiming", "BatchType", "CourseId" },
                values: new object[] { "10:00 AM - 1:00 PM", "Full-Time", 3 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CourseName", "Description" },
                values: new object[] { "Mathematics 101", "Basic Mathematics" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CourseName", "Description" },
                values: new object[] { "Physics 101", "Fundamentals of Physics" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseName", "Description", "TeacherId" },
                values: new object[] { "Advanced Math", "Advanced Topics in Math", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Email",
                value: "admin@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "Email",
                value: "john@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "Email",
                value: "jane@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "Email",
                value: "mark@example.com");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "Email",
                value: "alice@example.com");
        }
    }
}
