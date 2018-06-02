using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonkeyChat.Data.Models;

namespace MonkeyChat.App.Data
{
    public class MonkeyChatDbContext : IdentityDbContext<User>
    {
        public MonkeyChatDbContext(DbContextOptions<MonkeyChatDbContext> options)
            : base(options)
        {
        }

        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserChat> UserChats { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.SenderId);

            builder.Entity<Message>()
                .HasOne(m => m.Chat)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ChatId);

            builder.Entity<UserChat>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserChats)
                .HasForeignKey(uc => uc.UserId);

            builder.Entity<UserChat>()
                .HasOne(uc => uc.Chat)
                .WithMany(c => c.UserChats)
                .HasForeignKey(uc => uc.ChatId);

            builder.Entity<UserChat>()
                .HasKey(uc => new { uc.UserId, uc.ChatId });

            base.OnModelCreating(builder);
        }
    }
}
