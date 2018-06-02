using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonkeyChat.Data.Models
{
    public class UserChat
    {
        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
