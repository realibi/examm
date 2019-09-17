using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headhunter.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Apply> Applies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
            new City[]
            {
                new City { Id = 1, Name = "Nur-Sultan" },
                new City { Id = 2, Name = "Almaty" },
                new City { Id = 3, Name = "Karaganda" },
                new City { Id = 4, Name = "Aktau" },
                new City { Id = 5, Name = "Atyrau" }
            });

            modelBuilder.Entity<Vacancy>().HasData(
            new Vacancy[]
            {
                new Vacancy{
                    Id = 1,
                    Title = "Копирайтер",
                    Salary = 150000,
                    CompanyName = "CopyWrite",
                    CompanyAddress = "Сейфуллина 40",
                    Duties = "Набирать текст",
                    Conditions = "5/2, стабильная зарплата",
                    OwnerId = 1,
                    CreatedTime = DateTime.Now
                }
            });

            modelBuilder.Entity<User>().HasData(
            new User[]
            {
                new User
                {
                    Id = 1,
                    Login = "admin",
                    Password = "admin",
                    FullName = "Administrator Adminovich",
                    BirthYear = 2001,
                    Email = "admin@admin.kz",
                    CreatedTime = DateTime.Now
                },
                new User
                {
                    Id = 2,
                    Login = "alibi",
                    Password = "mypass123",
                    FullName = "Алиби Ерланович",
                    BirthYear = 2001,
                    Email = "alibi@mail.ru",
                    CreatedTime = DateTime.Now
                },
                new User
                {
                    Id = 3,
                    Login = "ivan",
                    Password = "yaivan777",
                    FullName = "Иван Михалыч",
                    BirthYear = 1960,
                    Email = "ivann@gmail.com",
                    CreatedTime = DateTime.Now
                }
            });

            modelBuilder.Entity<Resume>().HasData(
            new Resume[]
            {
                new Resume{
                    Id = 1,
                    OwnerId = 2,
                    FullName = "Дуйсеналиев Алиби Ерланович",
                    DesiredPosition = "Middle PHP dev",
                    HasExperience = true,
                    DesiredSalary = 100000,
                    HighEducations = "KazATU - 2022",
                    Skills = "Работал на High-Load",
                    Description = "C 18.11.2017 обучаюсь в Компьютерной Академии \"ШАГ\" на факультете \"Разработка ПО\"." +
                    "В будущем хочу работать и развиваться в сфере разработки ПО.",
                    LanguagesKnowlegde = "English - B2. Русский - в совершенстве. Казахский - родной.",
                    LearnedCourses = "ITSTEP - 2020",
                    CreatedTime = DateTime.Now
                },

                new Resume{
                    Id = 2,
                    OwnerId = 1,
                    FullName = "Администратор Админ",
                    DesiredPosition = "Senior .Net Developer",
                    HasExperience = true,
                    DesiredSalary = 900000,
                    HighEducations = "Harvard - 2005",
                    Skills = "Работал на High-Load",
                    Description = "C 18.11.2017 обучаюсь в Компьютерной Академии \"ШАГ\" на факультете \"Разработка ПО\"." +
                    "В будущем хочу работать и развиваться в сфере разработки ПО.",
                    LanguagesKnowlegde = "English - родной",
                    LearnedCourses = "ITSTEP - 2020",
                    CreatedTime = DateTime.Now
                }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
