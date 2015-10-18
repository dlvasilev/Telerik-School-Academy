using Shop.Areas.Shop.Models;
using Shop.Data;
using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace Shop.Areas.Shop.Controllers
{
    public class ShopController : Controller
    {
        private ShopContext context = new ShopContext();

        public ActionResult Products()
        {
            if (this.context.Products.Any())
            {
                return View(context.Products.ToList());
            }
            return RedirectToAction("NoProducts");
        }

        public ActionResult NoProducts()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var prod = new Product()
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Category = product.Category,
                    CreatedOn = DateTime.Now
                };
                this.context.Products.Add(prod);
                this.context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Product product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var dbProduct = context.Products.FirstOrDefault(x => x.Id == product.Id);

                dbProduct.Name = product.Name;
                dbProduct.Description = product.Description;
                dbProduct.Price = product.Price;
                dbProduct.Category = product.Category;
                dbProduct.LastModifiedOn = DateTime.Now;

                context.SaveChanges();
                return RedirectToAction("Products");
            }
            return View(product);
        }

        public ActionResult Details(int id)
        {
            Product product = context.Products.Find(id);
            return View(product);
        }

        public ActionResult DeleteProduct(int id)
        {
            Product product = context.Products.Find(id);
            this.context.Products.Remove(product);
            this.context.SaveChanges();
            return RedirectToAction("Products");
        }
    }
}