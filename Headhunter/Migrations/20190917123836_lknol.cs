using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class lknol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 18, 37, 51, 790, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 18, 37, 51, 790, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 18, 37, 51, 789, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 18, 37, 51, 789, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 18, 37, 51, 789, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 18, 37, 51, 728, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 2, 12, 25, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 2, 12, 25, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 2, 12, 25, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 2, 12, 25, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 2, 12, 25, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 2, 12, 25, 308, DateTimeKind.Local));
        }
    }
}
