using Lesson5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson5.Controllers
{
    public class HomeController : Controller
    {
        public List<Product> prods = new List<Product>();


        public ActionResult Index()
        {
            return View(prods);
        }

        public ActionResult Create()
        {
            Product prod = new Product();
            prod.Id = 1;
            prod.Name = "Unknown";
            prod.MyProperty = "Unknown";
            prod.Sure = false;



            return View(prod);
        }
        [HttpPost]
        public ActionResult Create(Product income)
        {
            prods.Add(income);
            ViewBag.prods = prods;

            Console.WriteLine("Name " + income.Name);
            Console.WriteLine("Type " + income.MyProperty);
            Console.WriteLine("Sure " + income.Sure);

            ViewBag.Name = income.Name;

            return View("Succes");
        }
    }
}