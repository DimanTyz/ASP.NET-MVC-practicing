using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2_Routing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Num = RouteData.Values["id"];
            return View();
        }

        public ActionResult NumInd(int? id)
        {
            ViewBag.Num = id;
            return View("Index");
        }
    }
}