using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headhunter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Headhunter.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        ApplicationContext db;
        
        public UserController(ApplicationContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public List<User> Get()
        {
            return db.Users.ToList();
        }

        [HttpPost]
        [Route("SignIn")]
        public IActionResult SignIn([FromBody]User user)
        {
            foreach(var item in db.Users)
            {
                if(user.Login == item.Login && user.Password == item.Password)
                    return Ok(db.Users.FirstOrDefault(x=>x.Login==user.Login));      
            }

            return BadRequest();
        }

        // GET api/users/5
        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        [HttpGet]
        [Route("notifications/{userLogin}")]
        public List<Notification> GetNotifications(string userLogin)
        {
            if (userLogin == "null")
                return new List<Notification>();

            List<Notification> notifications = new List<Notification>();

            foreach (var item in db.Notifications)
            {
                var user = db.Users.FirstOrDefault(x => x.Login == userLogin);
                if (item.UserId == user.Id && item.IsSeen == false)
                    notifications.Add(item);
            }

            return notifications;
        }

        // POST api/user
        [HttpPost]
        [Route("SignUp")]
        public IActionResult Post([FromBody]User user)
        {
            if (user == null)
                return BadRequest();

            foreach(var item in db.Users)
            {
                if (user.Login == item.Login || user.Password == item.Password)
                    return BadRequest();
            }

            user.CreatedTime = DateTime.Now;

            db.Users.Add(user);
            db.SaveChanges();
            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            if (!db.Users.Any(x => x.Id == user.Id))
            {
                return NotFound();
            }

            db.Update(user);
            db.SaveChanges();
            return Ok(user);
        }

        // DELETE api/users/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            db.Users.Remove(user);
            db.SaveChanges();
            return Ok(user);
        }
    }
}