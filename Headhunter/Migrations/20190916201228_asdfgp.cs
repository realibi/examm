using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class asdfgp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Resumes",
                columns: new[] { "Id", "AbleToRelocate", "AvatarUrl", "City", "CreatedTime", "Description", "DesiredPosition", "DesiredSalary", "FullName", "HasExperience", "HighEducations", "LanguagesKnowlegde", "LearnedCourses", "OwnerId", "Skills" },
                values: new object[,]
                {
                    { 1, false, null, null, new DateTime(2019, 9, 17, 2, 12, 25, 310, DateTimeKind.Local), "C 18.11.2017 обучаюсь в Компьютерной Академии \"ШАГ\" на факультете \"Разработка ПО\".В будущем хочу работать и развиваться в сфере разработки ПО.", "Middle PHP dev", 100000, "Дуйсеналиев Алиби Ерланович", true, "KazATU - 2022", "English - B2. Русский - в совершенстве. Казахский - родной.", "ITSTEP - 2020", 2, "Работал на High-Load" },
                    { 2, false, null, null, new DateTime(2019, 9, 17, 2, 12, 25, 310, DateTimeKind.Local), "C 18.11.2017 обучаюсь в Компьютерной Академии \"ШАГ\" на факультете \"Разработка ПО\".В будущем хочу работать и развиваться в сфере разработки ПО.", "Senior .Net Developer", 900000, "Администратор Админ", true, "Harvard - 2005", "English - родной", "ITSTEP - 2020", 1, "Работал на High-Load" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resumes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 1, 43, 41, 629, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 1, 43, 41, 630, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 1, 43, 41, 630, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 17, 1, 43, 41, 628, DateTimeKind.Local));
        }
    }
}
