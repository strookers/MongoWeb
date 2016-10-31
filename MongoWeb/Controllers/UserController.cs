using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoWeb.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoWeb.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            //Connect to MongoDB
            MongoClient client = new MongoClient("mongodb://admin:admin123@95.85.45.220:27017/");

            var db = client.GetDatabase("campanion");

            var collection = db.GetCollection<User>("test");
            user.ID = Guid.NewGuid();
            collection.InsertOne(user);

            return View();
        }
    }
}