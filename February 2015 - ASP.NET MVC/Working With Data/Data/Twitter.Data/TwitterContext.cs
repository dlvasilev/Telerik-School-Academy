namespace Twitter.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using Twitter.Data.Migrations;
    using Twitter.Data.Models;

    public class TwitterContext : IdentityDbContext<ApplicationUser>
    {
        public TwitterContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterContext, Configuration>());
        }
        public IDbSet<Tweet> Tweets { get; set; }

        public IDbSet<Follower> Followers { get; set; }

        public static TwitterContext Create()
        {
            return new TwitterContext();
        }
    }
}
