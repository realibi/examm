using System;
using System.Collections.Generic;

namespace Headhunter.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }     
        public string Password { get; set; }
        public string FullName { get; set; }
        public string AvatarSrc { get; set; }
        public int BirthYear { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}