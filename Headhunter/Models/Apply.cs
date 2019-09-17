using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headhunter.Models
{
    public class Apply
    {
        public int Id { get; set; }
        public int ResumeId { get; set; }
        public int VacancyId { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
