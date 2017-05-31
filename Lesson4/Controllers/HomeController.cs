using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            //ViewBag.user = User.Identity.Name;
            //ViewBag.machine = Server.MachineName;
            //ViewBag.serv = Request.UserHostAddress;
            //ViewBag.dat = Request.Form["data"];
            //ViewBag.qdat = Request.QueryString["data"];

            string filename = Server.MapPath("/Content/doc.pdf");
            string conttype = "application/pdf";

            byte[] data = System.IO.File.ReadAllBytes(filename);

            return File(data, conttype);




            //return View();
        }

    }
}