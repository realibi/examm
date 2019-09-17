using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headhunter.Models
{
    public class VacancyViewModel
    {
        public string Title { get; set; }
        public int Salary { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Duties { get; set; } //обязанности
        public string Conditions { get; set; } //условия работы
        public string OwnerLogin { get; set; }
    }
}
