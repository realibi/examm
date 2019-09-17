using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headhunter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Headhunter.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ApplicationContext db;

        NotificationController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        public List<Notification> Get()
        {
            return db.Notifications.ToList();
        }

        
    }
}