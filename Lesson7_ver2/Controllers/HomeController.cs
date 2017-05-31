//using Lesson7.Models;
using Lesson7_ver2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Lesson7_ver2.Controllers
{
    public class HomeController : Controller
    {
        private UserModel db = new UserModel();

        // GET: Home
        public ActionResult Index()
        {
            return HttpNotFound();

          
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
            return View(db.Users.ToList());
        }
    }
}