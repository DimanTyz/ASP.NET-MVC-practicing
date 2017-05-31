using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2_Routing.Areas.ProductArea.Controllers
{
    public class ComputerController : Controller
    {
        // GET: ProductArea/Computer
        public ActionResult Show()
        {
            return View();
        }
    }
}