using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class qwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Applies",
                newName: "ResumeId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 12, 1, 30, 8, 626, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 12, 1, 30, 8, 626, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 12, 1, 30, 8, 626, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 12, 1, 30, 8, 625, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResumeId",
                table: "Applies",
                newName: "UserId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 11, 23, 55, 32, 545, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 11, 23, 55, 32, 545, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 11, 23, 55, 32, 545, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 11, 23, 55, 32, 543, DateTimeKind.Local));
        }
    }
}
