using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Headhunter.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NotificationText = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    AvatarSrc = table.Column<string>(nullable: true),
                    BirthYear = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    Duties = table.Column<string>(nullable: true),
                    Conditions = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nur-Sultan" },
                    { 2, "Almaty" },
                    { 3, "Karaganda" },
                    { 4, "Aktau" },
                    { 5, "Atyrau" }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "CreatedTime", "NotificationText", "UserId" },
                values: new object[] { 1, new DateTime(2019, 9, 6, 23, 29, 38, 381, DateTimeKind.Local), "У вас новое приглашение на работу!", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarSrc", "BirthYear", "CreatedTime", "Email", "FullName", "Login", "Password" },
                values: new object[,]
                {
                    { 1, null, 0, new DateTime(2019, 9, 6, 23, 29, 38, 380, DateTimeKind.Local), "admin@admin.kz", null, "admin", "admin" },
                    { 2, null, 0, new DateTime(2019, 9, 6, 23, 29, 38, 380, DateTimeKind.Local), "alibi@mail.ru", null, "alibi", "mypass123" },
                    { 3, null, 0, new DateTime(2019, 9, 6, 23, 29, 38, 380, DateTimeKind.Local), "ivann@gmail.com", null, "ivan", "yaivan777" }
                });

            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "CompanyAddress", "CompanyName", "Conditions", "CreatedTime", "Duties", "Salary", "Title" },
                values: new object[] { 1, "Сейфуллина 40", "CopyWrite", "5/2, стабильная зарплата", new DateTime(2019, 9, 6, 23, 29, 38, 379, DateTimeKind.Local), "Набирать текст", 150000, "Копирайтер" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vacancies");
        }
    }
}
