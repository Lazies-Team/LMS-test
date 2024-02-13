using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserOneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 14, 0, 48, 16, 800, DateTimeKind.Local).AddTicks(150),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 14, 0, 48, 16, 799, DateTimeKind.Local).AddTicks(9735),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 48, 16, 799, DateTimeKind.Local).AddTicks(9735), new DateTime(2024, 2, 14, 0, 48, 16, 800, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 48, 16, 799, DateTimeKind.Local).AddTicks(9735), new DateTime(2024, 2, 14, 0, 48, 16, 800, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 14, 0, 48, 16, 799, DateTimeKind.Local).AddTicks(9735), new DateTime(2024, 2, 14, 0, 48, 16, 800, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_UserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Admins_UserId",
                table: "Admins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(6211),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 2, 14, 0, 48, 16, 800, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(5295),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2024, 2, 14, 0, 48, 16, 799, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(5295), new DateTime(2024, 2, 13, 22, 37, 58, 364, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");
        }
    }
}
