using System;
using System.Collections.Generic;
using System.Text;

namespace Headhunter.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Duties { get; set; } //обязанности
        public string Conditions { get; set; } //условия работы
        public int OwnerId { get; set; } //Id создателя вакансии
        public DateTime? CreatedTime { get; set; }
    }
}
