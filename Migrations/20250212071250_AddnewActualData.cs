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
            migrationBuilder.CreateTable(
                name: "Contactus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    SubjectSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchTiming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BatchType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.BatchId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId");
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    BatchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "Batches",
                        principalColumn: "BatchId");
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ContactDetails", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "1234567890", "admin@gmail.com", "Admin User", "admin123", "Admin" },
                    { 2, "9876543210", "john.doe@gmail.com", "John Doe", "password123", "Student" },
                    { 3, "5554443333", "jane.smith@gmail.com", "Jane Smith", "teacher123", "Teacher" },
                    { 4, "6667778888", "mark.johnson@gmail.com", "Mark Johnson", "teacher456", "Teacher" },
                    { 5, "9990001111", "alice.brown@gmail.com", "Alice Brown", "student123", "Student" },
                    { 6, "2345678901", "tom.hanks@gmail.com", "Tom Hanks", "student456", "Student" },
                    { 7, "3456789012", "emma.watson@gmail.com", "Emma Watson", "student789", "Student" },
                    { 8, "4567890123", "robert.downey@gmail.com", "Robert Downey", "teacher789", "Teacher" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "SubjectSpecialization", "UserId" },
                values: new object[,]
                {
                    { 1, "Fullstack Development with .NET", 3 },
                    { 2, "DevOps", 4 },
                    { 3, "Cyber Security", 8 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "BatchId", "CourseName", "Description", "TeacherId" },
                values: new object[,]
                {
                    { 1, null, "Fullstack Development with .NET", "Learn to build modern full-stack applications using .NET.", 1 },
                    { 2, null, "Fullstack Development with Python", "Master full-stack development with Python and related frameworks.", 2 },
                    { 3, null, "Frontend Development with React", "Learn to build dynamic UIs using React.", 3 },
                    { 4, null, "Software Testing", "Understand the principles and practices of software testing.", 1 },
                    { 5, null, "DevOps", "Learn to automate the software delivery pipeline with DevOps practices.", 2 },
                    { 6, null, "Salesforce", "Learn how to develop on the Salesforce platform.", 3 },
                    { 7, null, "Cloud Computing", "Understand cloud computing principles and how to work with cloud providers.", 1 },
                    { 8, null, "Data Analyst", "Master the techniques of data analysis using Python and Excel.", 2 },
                    { 9, null, "Cyber Security", "Learn how to secure applications and networks from cyber threats.", 3 },
                    { 10, null, "Android Development", "Develop mobile applications for Android using Java and Kotlin.", 1 },
                    { 11, null, "Artificial Intelligence", "Dive into AI concepts and build intelligent systems with Python.", 2 },
                    { 12, null, "Power BI", "Learn how to visualize and analyze data using Power BI.", 3 }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "BatchId", "BatchName", "BatchTiming", "BatchType", "CourseId" },
                values: new object[,]
                {
                    { 1, "Batch A", "8:00 AM - 9:30 AM", "Weekdays", 1 },
                    { 2, "Batch B", "10:00 AM - 11:30 AM", "Weekdays", 2 },
                    { 3, "Batch C", "12:00 PM - 1:30 PM", "Weekdays", 4 },
                    { 4, "Batch D", "2:00 PM - 3:30 PM", "Weekdays", 3 },
                    { 5, "Batch E", "4:00 PM - 5:30 PM", "Weekdays", 5 },
                    { 6, "Batch F", "6:00 PM - 7:30 PM", "Weekdays", 6 },
                    { 7, "Batch G", "8:00 AM - 9:30 AM", "Weekend", 7 },
                    { 8, "Batch H", "10:00 AM - 11:30 AM", "Weekend", 8 },
                    { 9, "Batch I", "12:00 PM - 1:30 PM", "Weekend", 9 },
                    { 10, "Batch J", "2:00 PM - 3:30 PM", "Weekend", 10 },
                    { 11, "Batch K", "4:00 PM - 5:30 PM", "Weekend", 11 },
                    { 12, "Batch L", "6:00 PM - 7:30 PM", "Weekend", 12 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BatchId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 5 },
                    { 3, 3, 6 },
                    { 4, 4, 7 },
                    { 5, 5, 8 }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 4, 3 },
                    { 3, 4 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_CourseId",
                table: "Batches",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_BatchId",
                table: "Courses",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BatchId",
                table: "Students",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Users_UserId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Contactus");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
