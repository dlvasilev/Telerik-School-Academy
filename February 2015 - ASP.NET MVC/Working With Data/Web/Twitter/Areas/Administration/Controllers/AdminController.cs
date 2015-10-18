using AutoMapper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;
using Twitter.Areas.Administration.ViewModels;
using Twitter.Data.Common;
using Twitter.Data.Models;

namespace Twitter.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        IUowData db;

        public AdminController(IUowData db)
        {
            this.db = db;
        }

        public AdminController()
        {
            db = new UowData();
        }

        // GET: Administration/Admin
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult CreateUser([DataSourceRequest] DataSourceRequest request, UserViewModel user)
        {
            if (user != null && ModelState.IsValid)
            {
                var hasher = new PasswordHasher();

                var newUser = new ApplicationUser
                {
                    UserName = user.UserName,
                    PasswordHash = hasher.HashPassword(user.PasswordHash),
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = user.CreatedOn,
                    IsAdmin = user.IsAdmin
                };

                this.db.Users.Add(newUser);
                this.db.SaveChanges();
                user.Id = newUser.Id;
            }

            return Json(new[] { user }.ToDataSourceResult(request, ModelState), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ReadUsers([DataSourceRequest]
                                    DataSourceRequest request)
        {
            var users = this.db.Users.All().Select(UserViewModel.FromUsers);
            return Json(users.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult UpdateUser([DataSourceRequest]
                                      DataSourceRequest request, UserViewModel user)
        {
            var existingUser = this.db.Users.All().FirstOrDefault(u => u.Id == user.Id);

            if (user != null && ModelState.IsValid)
            {
                var hasher = new PasswordHasher();

                existingUser.UserName = user.UserName;
                existingUser.PasswordHash = hasher.HashPassword(user.PasswordHash);
                existingUser.Email = user.Email;
                existingUser.EmailConfirmed = user.EmailConfirmed;
                existingUser.SecurityStamp = Guid.NewGuid().ToString();
                existingUser.CreatedOn = user.CreatedOn;
                existingUser.IsAdmin = user.IsAdmin;

                this.db.SaveChanges();
            }

            return Json((new[] { user }.ToDataSourceResult(request, ModelState)), JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteUser([DataSourceRequest]
                                      DataSourceRequest request, UserViewModel user)
        {
            var existingBook = this.db.Users.All().FirstOrDefault(u => u.Id == user.Id);

            this.db.Users.Delete(existingBook);
            this.db.SaveChanges();

            return Json(new[] { user }, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult Read([DataSourceRequest]DataSourceRequest request)
        //{
        //    var users = this.db.Users.All();
        //    DataSourceResult result = users.ToDataSourceResult(request);
        //    return Json(result);
        //}

        //public ActionResult Create([DataSourceRequest]DataSourceRequest request, ApplicationUser model)
        //{
        //    if (model != null && ModelState.IsValid)
        //    {
        //        var hasher = new PasswordHasher();

        //        var newUser = new ApplicationUser
        //        {
        //            UserName = model.UserName,
        //            PasswordHash = hasher.HashPassword(model.PasswordHash),
        //            Email = model.Email,
        //            EmailConfirmed = model.EmailConfirmed,
        //            SecurityStamp = Guid.NewGuid().ToString(),
        //            CreatedOn = model.CreatedOn,
        //            Followers = model.Followers,
        //            Tweets = model.Tweets,
        //            IsAdmin = model.IsAdmin
        //        };

        //        this.db.Users.Add(newUser);
        //        this.db.SaveChanges();
        //        model.Id = newUser.Id;
        //    }
        //    return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        //}

        //[HttpPost]
        //public ActionResult Update([DataSourceRequest]DataSourceRequest request, ApplicationUser model)
        //{
        //    if (model != null && ModelState.IsValid)
        //    {
        //        var user = this.db.Users.All().Where(us => us.Id == model.Id).FirstOrDefault();
        //        Mapper.Map(model, user);
        //        this.db.SaveChanges();
        //    }
        //    return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        //}

        //[HttpPost]
        //public ActionResult Destroy([DataSourceRequest]DataSourceRequest request, ApplicationUser model)
        //{
        //    if (model != null && ModelState.IsValid)
        //    {
        //        var user = this.db.Users.All().Where(us => us.Id == model.Id).FirstOrDefault();
        //        this.db.Users.Delete(user);
        //        this.db.SaveChanges();
        //    }
        //    return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        //}
    }
}