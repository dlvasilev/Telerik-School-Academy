using System;
using Twitter.Data.Models;

namespace Twitter.Data.Common
{
    public interface IUowData : IDisposable
    {
        IRepository<Tweet> Tweets { get; }

        IRepository<Follower> Followers { get; }

        IRepository<ApplicationUser> Users { get; }

        int SaveChanges();
    }
}
