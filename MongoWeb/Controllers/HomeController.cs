using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using MongoWeb.Models;

namespace MongoWeb.Controllers
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
            MongoClient client = new MongoClient("mongodb://admin:admin123@95.85.45.220:27017/");

            var db = client.GetDatabase("campanion");

            var collection = db.GetCollection<User>("test");

            List<User> users = collection.AsQueryable().ToList();
            return View(users);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}