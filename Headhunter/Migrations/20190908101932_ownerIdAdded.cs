using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class ownerIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Vacancies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 16, 19, 32, 432, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 16, 19, 32, 432, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 16, 19, 32, 432, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 16, 19, 32, 432, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "OwnerId" },
                values: new object[] { new DateTime(2019, 9, 8, 16, 19, 32, 430, DateTimeKind.Local).AddTicks(9761), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Vacancies");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 15, 39, 1, 570, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 15, 39, 1, 568, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 15, 39, 1, 568, DateTimeKind.Local).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 15, 39, 1, 568, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 8, 15, 39, 1, 539, DateTimeKind.Local).AddTicks(7631));
        }
    }
}
