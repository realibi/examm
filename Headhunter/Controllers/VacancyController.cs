using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headhunter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Headhunter.Controllers
{
    [Route("api/vacancy")]
    [ApiController]
    public class VacancyController : ControllerBase
    {
        ApplicationContext db;

        public VacancyController(ApplicationContext context)
        {
            this.db = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody]VacancyViewModel model)
        {
            if (model == null)
                return BadRequest();

            Vacancy vacancy = new Vacancy();
            vacancy.Title = model.Title;
            vacancy.Salary = model.Salary;
            vacancy.CompanyName = model.CompanyName;
            vacancy.CompanyAddress = model.CompanyAddress;
            vacancy.Duties = model.Duties;
            vacancy.Conditions = model.Conditions;
            vacancy.OwnerId = db.Users.FirstOrDefault(x => x.Login == model.OwnerLogin).Id;
            vacancy.CreatedTime = DateTime.Now;

            db.Vacancies.Add(vacancy);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public List<Vacancy> Get()
        {
            return db.Vacancies.OrderByDescending(x => x.CreatedTime).ToList();
        }

        [HttpGet]
        [Route("search/{searchText}")]
        public List<Vacancy> Get(string searchText)
        {
            return db.Vacancies.OrderByDescending(x => x.Title.Contains(searchText)).ToList();
        }

        [HttpGet]
        [Route("company/{searchText}")]
        public List<Vacancy> GetCompany(string searchText)
        {
            return db.Vacancies.OrderByDescending(x => x.CompanyName == searchText).ToList();
        }

        [HttpGet]
        [Route("id/{id}")]
        public Vacancy Get(int id)
        {
            Vacancy result = db.Vacancies.FirstOrDefault(vacancy => vacancy.Id == id);
            return result;
        }

        [HttpGet]
        [Route("appliedResumes/{id}")]
        public List<Resume> AppliedResumes(int id)
        {
            List<Apply> appliesToThisVacancy = new List<Apply>();
            foreach(var item in db.Applies)
            {
                if (item.VacancyId == id)
                    appliesToThisVacancy.Add(item);
            }

            List<Resume> result = new List<Resume>();
            foreach(var item in appliesToThisVacancy)
            {
                result.Add(db.Resumes.FirstOrDefault(x => x.Id == item.ResumeId));
            }

            return result;
        }

        [HttpGet]
        [Route("headerInfo")]
        public List<int> GetHeaderInfo() //список информации для хэдера: кол-во резюме, вакансии и пользователей
        {
            List<int> result = new List<int>();
            result.Add(db.Resumes.Count());
            result.Add(db.Vacancies.Count());
            result.Add(db.Users.Count());
            return result;
        }

        [HttpPost]
        [Route("ApplyToVacancy")]
        public IActionResult ApllyToVacancy(ApplyingViewModel model) //список информации для хэдера: кол-во резюме, вакансии и пользователей
        {
            Resume appliedResume = db.Resumes.FirstOrDefault(x => x.Id == model.ResumeId);

            User appliedUser = db.Users.FirstOrDefault(x => x.Id == appliedResume.OwnerId);

            Vacancy appliedVacancy = db.Vacancies.FirstOrDefault(x => x.Id == model.VacancyId);

            db.Applies.Add(new Apply
            {
                ResumeId = model.ResumeId,
                VacancyId = appliedVacancy.Id,
                CreatedTime = DateTime.Now
            });

            db.Notifications.Add(
                new Notification
                {
                    NotificationText = "На вашу вакансию \"" + appliedVacancy.Title + "\" откликнулся пользователь \"" + appliedUser.FullName + "\"!",
                    UserId = appliedVacancy.OwnerId,
                    IsSeen = false,
                    CreatedTime = DateTime.Now
                }
             );

            db.SaveChanges();

            return Ok();
        }

        [HttpPost]
        [Route("seenotification/{id}")]
        public void SeeNotification(int id)
        {
            db.Notifications.FirstOrDefault(x => x.Id == id).IsSeen = true;
            db.Update(db.Notifications.FirstOrDefault(x => x.Id == id));
            db.SaveChanges();
        }

        [HttpPost]
        [Route("invitetojob")]
        public void InviteToJob(InvitingToJobViewModel model)
        {
            Vacancy appliedVacancy = db.Vacancies.FirstOrDefault(x => x.Id == model.VacancyId);

            db.Notifications.Add(
                new Notification
                {
                    NotificationText = "Вас позвали на собеседование на должность \"" + appliedVacancy.Title + "!",
                    UserId = model.UserId,
                    IsSeen = false,
                    CreatedTime = DateTime.Now
                }
             );

            db.SaveChanges();
        }
    }
}