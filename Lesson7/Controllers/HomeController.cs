using Lesson7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson7.Controllers
{
    public class HomeController : Controller
    {
        private UserModel db = new UserModel();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User model)
        {
            if (ModelState.IsValid)
            {
                
                    //User us = model;
                    db.Users.Add(model);
                    db.SaveChanges();
                
                ViewBag.UserName = model.Login;
                return View("Success");
            }

            return View();
        }

        public ActionResult DB()
        {
            return View(db);
        }
    }
}