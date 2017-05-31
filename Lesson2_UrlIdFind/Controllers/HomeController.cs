using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2_UrlIdFind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.var = RouteData.Values["id"];

            return View();
        }


        public ActionResult Res(int? id)
        {
            ViewBag.var = id;
            return View("Index");
        }

     
    }
}