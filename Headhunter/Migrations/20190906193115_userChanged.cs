using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class userChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 31, 14, 815, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthYear", "CreatedTime", "FullName" },
                values: new object[] { 2001, new DateTime(2019, 9, 7, 1, 31, 14, 814, DateTimeKind.Local), "Administrator Adminovich" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthYear", "CreatedTime", "FullName" },
                values: new object[] { 2001, new DateTime(2019, 9, 7, 1, 31, 14, 815, DateTimeKind.Local), "Алиби Ерланович" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthYear", "CreatedTime", "FullName" },
                values: new object[] { 1960, new DateTime(2019, 9, 7, 1, 31, 14, 815, DateTimeKind.Local), "Иван Михалыч" });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 31, 14, 813, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 6, 23, 29, 38, 381, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthYear", "CreatedTime", "FullName" },
                values: new object[] { 0, new DateTime(2019, 9, 6, 23, 29, 38, 380, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthYear", "CreatedTime", "FullName" },
                values: new object[] { 0, new DateTime(2019, 9, 6, 23, 29, 38, 380, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthYear", "CreatedTime", "FullName" },
                values: new object[] { 0, new DateTime(2019, 9, 6, 23, 29, 38, 380, DateTimeKind.Local), null });

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 6, 23, 29, 38, 379, DateTimeKind.Local));
        }
    }
}
