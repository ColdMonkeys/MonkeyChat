using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MonkeyChat.Data.Models
{
    public class Message
    {
        public Guid Id { get; set; }

        [Required]
        public string Content { get; set; }

        public Guid ChatId { get; set; }
        public Chat Chat { get; set; }

        public string SenderId { get; set; }
        public User Sender { get; set; }
    }
}
