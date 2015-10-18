namespace Twitter.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using Twitter.Data.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TwitterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TwitterContext context)
        {
            if (context.Users.Any())
            {
                return;
            }
            this.AddUsers(context);
            this.AddAdmin(context);
        }

        private void AddUsers(TwitterContext context)
        {
            var hasher = new PasswordHasher();

            context.Users.AddOrUpdate(u => u.Id,
                new ApplicationUser
                {
                    UserName = "Pesho@abv.bg",
                    PasswordHash = hasher.HashPassword("123456"),
                    Email = "Pesho@abv.bg",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    Followers = new List<Follower>(),
                    Tweets = new List<Tweet>(),
                    IsAdmin = false,
                    LockoutEnabled = true
                },
                new ApplicationUser
                {
                    UserName = "Gosho@abv.bg",
                    PasswordHash = hasher.HashPassword("123456"),
                    Email = "Gosho@abv.bg",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    Followers = new List<Follower>(),
                    Tweets = new List<Tweet>(),
                    IsAdmin = false,
                    LockoutEnabled = true
                },
                new ApplicationUser
                {
                    UserName = "Mimi@abv.bg",
                    PasswordHash = hasher.HashPassword("123456"),
                    Email = "Mimi@abv.bg",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    Followers = new List<Follower>(),
                    Tweets = new List<Tweet>(),
                    IsAdmin = false,
                    LockoutEnabled = true
                },
                new ApplicationUser
                {
                    UserName = "Ivan@abv.bg",
                    PasswordHash = hasher.HashPassword("123456"),
                    Email = "Ivan@abv.bg",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    Followers = new List<Follower>(),
                    Tweets = new List<Tweet>(),
                    IsAdmin = false,
                    LockoutEnabled = true
                },
                new ApplicationUser
                {
                    UserName = "Stoqn@abv.bg",
                    PasswordHash = hasher.HashPassword("123456"),
                    Email = "Stoqn@abv.bg",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.Now,
                    Followers = new List<Follower>(),
                    Tweets = new List<Tweet>(),
                    IsAdmin = false,
                    LockoutEnabled = true
                });
        }

        private void AddAdmin(TwitterContext context)
        {
            const string RoleName = "Admin";

            var userRole = new IdentityRole { Name = RoleName, Id = Guid.NewGuid().ToString() };
            context.Roles.AddOrUpdate(userRole);

            var hasher = new PasswordHasher();

            var user = new ApplicationUser
            {
                UserName = "Admin@abv.bg",
                PasswordHash = hasher.HashPassword("123456"),
                Email = "Admin@abv.bg",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedOn = DateTime.Now,
                Followers = new List<Follower>(),
                Tweets = new List<Tweet>(),
                IsAdmin = true,
                LockoutEnabled = true
            };

            user.Roles.Add(new IdentityUserRole { RoleId = userRole.Id, UserId = user.Id });
            context.Users.AddOrUpdate(user);
        }
    }
}
