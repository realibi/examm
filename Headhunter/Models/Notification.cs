using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Headhunter.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string NotificationText { get; set; }
        public int UserId { get; set; }
        public bool IsSeen { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
