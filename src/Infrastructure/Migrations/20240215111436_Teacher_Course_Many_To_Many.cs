using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Teacher_Course_Many_To_Many : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RefreshTokenExpireDate",
                value: new DateTime(2024, 2, 16, 16, 14, 36, 49, DateTimeKind.Local).AddTicks(207));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RefreshTokenExpireDate",
                value: new DateTime(2024, 2, 16, 15, 31, 2, 712, DateTimeKind.Local).AddTicks(1190));
        }
    }
}
