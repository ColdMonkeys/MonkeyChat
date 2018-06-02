using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonkeyChat.Data.Models
{
    public class User : IdentityUser
    {
        public virtual User ParentUser { get; set; }

        public string ParentUserId { get; set; }
        
        public ICollection<UserChat> UserChats { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
