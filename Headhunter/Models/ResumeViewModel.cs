using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headhunter.Models
{
    public class ResumeViewModel
    {
        public string FullName { get; set; }
        public string City { get; set; }
        public bool AbleToRelocate { get; set; } // возможность переезда
        public string DesiredPosition { get; set; } // желаемая должность. ИНПУТ + СЕЛЕКТ
        public bool HasExperience { get; set; } // есть ли опыт
        public int DesiredSalary { get; set; } //желаемая ЗП
        public string HighEducations { get; set; } // высшие образования. ИНПУТ + СЕЛЕКТ
        public string Skills { get; set; } // особые скиллы. ИНПУТ + СЕЛЕКТ
        public string Description { get; set; } // "о себе"
        public string LanguagesKnowledge { get; set; } // уровень изучанных языков. ИНПУТ + СЕЛЕКТ
        public string LearnedCourses { get; set; } // инфа о пройденных курсах. ИНПУТ + СЕЛЕКТ
        public string OwnerLogin { get; set; }
    }
}
