namespace Twitter.Controllers
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Twitter.Data.Common;
    using Twitter.Data.Models;

    [Authorize]
    public class ProfileController : Controller
    {
        // TODO Last seen online (profile info)
        IUowData db;

        public ProfileController(IUowData db)
        {
            this.db = db;
        }

        public ProfileController()
        {
            db = new UowData();
        }

        // GET: Profile
        public ActionResult Index(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                id = User.Identity.GetUserId();
            };

            ApplicationUser user = this.db.Users.All().FirstOrDefault(us => us.Id == id);
            return View(user);
        }

        public ActionResult CreateTweetForm(string id)
        {
            TempData["userId"] = id;
            return PartialView("_TweetForm");
        }

        public ActionResult CreateTweet(Tweet inputTweet)
        {
            var userId = TempData["userId"];
            if (String.IsNullOrEmpty(inputTweet.Text))
            {
                return RedirectToAction("Index");
            };

            ApplicationUser user = this.db.Users.All().Where(us => us.Id == userId).FirstOrDefault();

            Tweet tweet = new Tweet()
            {
                Author = User.Identity.Name,
                Text = inputTweet.Text,
                PostedOn = DateTime.Now
            };

            tweet.ApplicationUser = user;

            this.db.Tweets.Add(tweet);
            this.db.SaveChanges();
            return View("Index", user);
        }

        public ActionResult SelectFollowers(string id)
        {
            var user = this.db.Users.All().FirstOrDefault(us => us.Id == id);

            if (user.Followers.Any())
            {
                var followers = user.Followers.OrderBy(f => f.UserName).ToList();
                return PartialView("_SelectFollowers", followers);
            }
            return null;
        }

        public ActionResult SelectTweets(string id)
        {
            ApplicationUser user = this.db.Users.All().Where(us => us.Id == id).FirstOrDefault();
            if (user.Tweets.Any())
            {
                var tweets = db.Tweets.All().Where(tw => tw.ApplicationUser.Id == user.Id).OrderByDescending(tw => tw.PostedOn).ToList();
                return PartialView("_SelectTweets", tweets);
            }
            return null;
        }

        public ActionResult SelectUsers(string searchTerm)
        {
            var users = db.Users.All().Where(u => u.UserName.ToLower().Contains(searchTerm.ToLower()) && u.UserName != User.Identity.Name).OrderBy(m => m.UserName).ToList();
            return View("SelectUsers", users);
        }

        public ActionResult Follow(string id)
        {
            var user = this.db.Users.All().FirstOrDefault(us => us.Id == id);

            Follower follower = new Follower()
            {
                UserName = this.User.Identity.Name.ToString()
            };

            var alreadyFollow = user.Followers.Where(us => us.UserName == follower.UserName).Select(us => us.UserName);

            if (alreadyFollow.Any())
            {
                return View("Index", user);
            }

            user.Followers.Add(follower);
            this.db.SaveChanges();
            return View("Index", user);
        }

        public ActionResult Unfollow(string id)
        {
            var user = this.db.Users.All().FirstOrDefault(us => us.Id == id);
            var unfolloweUser = user.Followers.Where(us => us.UserName == User.Identity.Name).FirstOrDefault();

            this.db.Followers.Delete(unfolloweUser);
            this.db.SaveChanges();

            return View("Index", user);
        }

        public ActionResult OnlyFollowers(string id)
        {
            var user = this.db.Users.All().FirstOrDefault(us => us.Id == id);
            var followers = user.Followers.OrderBy(f => f.UserName).ToList();
            return View("_SelectFollowers", followers);
        }
    }
}