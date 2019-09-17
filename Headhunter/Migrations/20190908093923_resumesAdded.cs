using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class resumesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvatarUrl = table.Column<string>(nullable: true),
                    OwnerId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    AbleToRelocate = table.Column<bool>(nullable: false),
                    DesiredPosition = table.Column<string>(nullable: true),
                    HasExperience = table.Column<bool>(nullable: false),
                    DesiredSalary = table.Column<int>(nullable: false),
                    HighEducations = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LanguagesKnowlegde = table.Column<string>(nullable: true),
                    LearnedCourses = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumes_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resumes_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_CityId",
                table: "Resumes",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_OwnerId",
                table: "Resumes",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 36, 7, 863, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 36, 7, 863, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 36, 7, 863, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 36, 7, 863, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 9, 7, 1, 36, 7, 862, DateTimeKind.Local));
        }
    }
}
