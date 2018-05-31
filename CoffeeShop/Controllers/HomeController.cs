using CoffeeShop.Models;
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
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            ViewBag.Items = ORM.Items.ToList();

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
        public ActionResult Registration()
        {

            return View();
        }
        public ActionResult CoffeeRegistration(User data)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();

            if (ModelState.IsValid)
            {

                ORM.Users.Add(data);
                ORM.SaveChanges();
                ViewBag.message = $"{data.FirstName}, you have been added!";
            }
            else
            {
                ViewBag.message = "Item is not valid, cannot add to DB.";
            }
            //CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            //ViewBag.FirstName = firstName;
            //ViewBag.LastName = lastName;
            //ViewBag.Email = email;
            //ViewBag.Phone = phone;
            //ViewBag.Password = password;
            //ViewBag.Gender = gender;
            //ViewBag.Subscription = subscription;
            return View();
        }
    }
}

//string firstName, string lastName, string email, int? phone,
//            string password, string gender, string subscription