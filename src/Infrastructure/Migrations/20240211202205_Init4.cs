using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Lesson_LessonId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Specialty_SpecialtyId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_TaskResult_TaskResultId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Lesson_LessonId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkFile_Homework_HomeworkId",
                table: "HomeworkFile");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Course_CourseId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskResult_Homework_HomeworkId",
                table: "TaskResult");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskResult_Students_StudentId",
                table: "TaskResult");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskResultFile_TaskResult_TaskResultId",
                table: "TaskResultFile");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_Lesson_LessonId",
                table: "Video");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_Teachers_TeacherId",
                table: "Video");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Video",
                table: "Video");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResultFile",
                table: "TaskResultFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResult",
                table: "TaskResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialty",
                table: "Specialty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkFile",
                table: "HomeworkFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homework",
                table: "Homework");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.RenameTable(
                name: "Video",
                newName: "Videos");

            migrationBuilder.RenameTable(
                name: "TaskResultFile",
                newName: "TaskResultFiles");

            migrationBuilder.RenameTable(
                name: "TaskResult",
                newName: "TaskResults");

            migrationBuilder.RenameTable(
                name: "Specialty",
                newName: "Specialties");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Lesson",
                newName: "Lessons");

            migrationBuilder.RenameTable(
                name: "HomeworkFile",
                newName: "HomeworkFiles");

            migrationBuilder.RenameTable(
                name: "Homework",
                newName: "Homeworks");

            migrationBuilder.RenameTable(
                name: "Grade",
                newName: "Grades");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.RenameIndex(
                name: "IX_Video_TeacherId",
                table: "Videos",
                newName: "IX_Videos_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Video_LessonId",
                table: "Videos",
                newName: "IX_Videos_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResultFile_TaskResultId",
                table: "TaskResultFiles",
                newName: "IX_TaskResultFiles_TaskResultId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResult_StudentId",
                table: "TaskResults",
                newName: "IX_TaskResults_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResult_HomeworkId",
                table: "TaskResults",
                newName: "IX_TaskResults_HomeworkId");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_CourseId",
                table: "Lessons",
                newName: "IX_Lessons_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkFile_HomeworkId",
                table: "HomeworkFiles",
                newName: "IX_HomeworkFiles_HomeworkId");

            migrationBuilder.RenameIndex(
                name: "IX_Homework_LessonId",
                table: "Homeworks",
                newName: "IX_Homeworks_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_TaskResultId",
                table: "Grades",
                newName: "IX_Grades_TaskResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendances",
                newName: "IX_Attendances_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_LessonId",
                table: "Attendances",
                newName: "IX_Attendances_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Videos",
                table: "Videos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResultFiles",
                table: "TaskResultFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResults",
                table: "TaskResults",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkFiles",
                table: "HomeworkFiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudents",
                columns: table => new
                {
                    CourseId = table.Column<long>(type: "INTEGER", nullable: false),
                    StudentId = table.Column<long>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudents", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_CourseStudents_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudents_CourseId",
                table: "CourseStudents",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Lessons_LessonId",
                table: "Attendances",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Specialties_SpecialtyId",
                table: "Course",
                column: "SpecialtyId",
                principalTable: "Specialties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_TaskResults_TaskResultId",
                table: "Grades",
                column: "TaskResultId",
                principalTable: "TaskResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkFiles_Homeworks_HomeworkId",
                table: "HomeworkFiles",
                column: "HomeworkId",
                principalTable: "Homeworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Lessons_LessonId",
                table: "Homeworks",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Course_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResultFiles_TaskResults_TaskResultId",
                table: "TaskResultFiles",
                column: "TaskResultId",
                principalTable: "TaskResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResults_Homeworks_HomeworkId",
                table: "TaskResults",
                column: "HomeworkId",
                principalTable: "Homeworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResults_Students_StudentId",
                table: "TaskResults",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Teachers_TeacherId",
                table: "Videos",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Lessons_LessonId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Specialties_SpecialtyId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_TaskResults_TaskResultId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkFiles_Homeworks_HomeworkId",
                table: "HomeworkFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Lessons_LessonId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Course_CourseId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskResultFiles_TaskResults_TaskResultId",
                table: "TaskResultFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskResults_Homeworks_HomeworkId",
                table: "TaskResults");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskResults_Students_StudentId",
                table: "TaskResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Lessons_LessonId",
                table: "Videos");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Teachers_TeacherId",
                table: "Videos");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "CourseStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Videos",
                table: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResults",
                table: "TaskResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResultFiles",
                table: "TaskResultFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specialties",
                table: "Specialties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkFiles",
                table: "HomeworkFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.RenameTable(
                name: "Videos",
                newName: "Video");

            migrationBuilder.RenameTable(
                name: "TaskResults",
                newName: "TaskResult");

            migrationBuilder.RenameTable(
                name: "TaskResultFiles",
                newName: "TaskResultFile");

            migrationBuilder.RenameTable(
                name: "Specialties",
                newName: "Specialty");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "Lesson");

            migrationBuilder.RenameTable(
                name: "Homeworks",
                newName: "Homework");

            migrationBuilder.RenameTable(
                name: "HomeworkFiles",
                newName: "HomeworkFile");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Grade");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_TeacherId",
                table: "Video",
                newName: "IX_Video_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_LessonId",
                table: "Video",
                newName: "IX_Video_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResults_StudentId",
                table: "TaskResult",
                newName: "IX_TaskResult_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResults_HomeworkId",
                table: "TaskResult",
                newName: "IX_TaskResult_HomeworkId");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResultFiles_TaskResultId",
                table: "TaskResultFile",
                newName: "IX_TaskResultFile_TaskResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CourseId",
                table: "Lesson",
                newName: "IX_Lesson_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_LessonId",
                table: "Homework",
                newName: "IX_Homework_LessonId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkFiles_HomeworkId",
                table: "HomeworkFile",
                newName: "IX_HomeworkFile_HomeworkId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_TaskResultId",
                table: "Grade",
                newName: "IX_Grade_TaskResultId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendance",
                newName: "IX_Attendance_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_LessonId",
                table: "Attendance",
                newName: "IX_Attendance_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Video",
                table: "Video",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResult",
                table: "TaskResult",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResultFile",
                table: "TaskResultFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specialty",
                table: "Specialty",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homework",
                table: "Homework",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkFile",
                table: "HomeworkFile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Lesson_LessonId",
                table: "Attendance",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Specialty_SpecialtyId",
                table: "Course",
                column: "SpecialtyId",
                principalTable: "Specialty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_TaskResult_TaskResultId",
                table: "Grade",
                column: "TaskResultId",
                principalTable: "TaskResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Lesson_LessonId",
                table: "Homework",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkFile_Homework_HomeworkId",
                table: "HomeworkFile",
                column: "HomeworkId",
                principalTable: "Homework",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Course_CourseId",
                table: "Lesson",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResult_Homework_HomeworkId",
                table: "TaskResult",
                column: "HomeworkId",
                principalTable: "Homework",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResult_Students_StudentId",
                table: "TaskResult",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResultFile_TaskResult_TaskResultId",
                table: "TaskResultFile",
                column: "TaskResultId",
                principalTable: "TaskResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Lesson_LessonId",
                table: "Video",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Teachers_TeacherId",
                table: "Video",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
