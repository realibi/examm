using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headhunter.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Headhunter.Controllers
{
    [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        private readonly ApplicationContext context;

        public CitiesController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return context.Cities.ToList();
        }
    }
}
