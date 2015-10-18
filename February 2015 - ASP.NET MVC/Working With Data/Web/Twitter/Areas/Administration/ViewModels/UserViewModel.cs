using System;
using System.Linq.Expressions;
using Twitter.Data.Models;

namespace Twitter.Areas.Administration.ViewModels
{
    public class UserViewModel
    {
        public static Expression<Func<ApplicationUser, UserViewModel>> FromUsers
        {
            get
            {
                return users => new UserViewModel
                {
                    Id = users.Id,
                    UserName = users.UserName,
                    Email = users.Email,
                    PasswordHash = users.PasswordHash,
                    EmailConfirmed = users.EmailConfirmed,
                    CreatedOn = users.CreatedOn,
                    IsAdmin = users.IsAdmin
                };
            }
        }

        public string Id { get; set; }

        public string PasswordHash { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsAdmin { get; set; }
    }
}