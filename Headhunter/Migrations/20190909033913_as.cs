using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Users_OwnerId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_CityId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_OwnerId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Resumes");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Resumes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Resumes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 9, 39, 12, 711, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 9, 39, 12, 711, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 9, 39, 12, 711, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 9, 39, 12, 710, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Resumes");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Resumes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Resumes",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 0, 24, 41, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 0, 24, 41, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 0, 24, 41, 88, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 9, 0, 24, 41, 87, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CityId",
                table: "Resumes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_OwnerId",
                table: "Resumes",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Cities_CityId",
                table: "Resumes",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Users_OwnerId",
                table: "Resumes",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
