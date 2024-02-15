using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Nulluble_Teachers_List : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RefreshTokenExpireDate",
                value: new DateTime(2024, 2, 17, 2, 17, 52, 858, DateTimeKind.Local).AddTicks(7353));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "RefreshTokenExpireDate",
                value: new DateTime(2024, 2, 16, 16, 14, 36, 49, DateTimeKind.Local).AddTicks(207));
        }
    }
}
