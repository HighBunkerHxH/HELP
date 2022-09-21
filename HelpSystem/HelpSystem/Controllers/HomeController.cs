using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "App description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }

        public ActionResult Question()
        {
            ViewBag.Message = "Questions";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "Insert your credentials";

            return View();
        }

        public ActionResult Upvote()
        {
            ViewBag.Message = "Upvotes";

            return View();
        }
        
        public int up_vote
        {
            get;
            set;
        }
        public int down_vote
        {
            get;
            set;
        }
    }
}