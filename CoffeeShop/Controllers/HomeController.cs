using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Registration(string firstName, string lastName, string email, int? phone, string password)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.Phone = phone;
            ViewBag.Password = password;
            return View();
        }
        public ActionResult CoffeeRegistration(string firstName, string lastName, string email, int? phone, string password)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.Phone = phone;
            ViewBag.Password = password;
            return View();
        }
    }
}