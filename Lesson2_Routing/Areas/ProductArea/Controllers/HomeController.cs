using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2_Routing.Areas.ProductArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: ProductArea/Home
        public ActionResult Index(int? id)
        {
            
            List<Product> sklad = new List<Product>
            {
                new Product{Id = 1, Name = "Asus", ProductType = ProdType.Computer},
                new Product{Id = 2, Name = "Acer", ProductType = ProdType.Computer},
                new Product{Id = 3, Name = "Iphone", ProductType = ProdType.Cellphone},
                new Product{Id = 4, Name = "Marshall", ProductType = ProdType.Headphone},
                new Product{Id = 0, Name = "Technika"}
            };

            ViewBag.Skald = sklad;


            return View(sklad);
        }
    }
}