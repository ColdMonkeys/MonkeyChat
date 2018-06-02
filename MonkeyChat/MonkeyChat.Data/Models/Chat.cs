using System;
using System.Collections.Generic;
using System.Text;

namespace MonkeyChat.Data.Models
{
    public class Chat
    {
        public Guid Id { get; set; }

        public ICollection<UserChat> UserChats { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
