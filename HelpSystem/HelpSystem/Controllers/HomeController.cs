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
            ViewBag.Message = "A descrição da aplicação.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "A página de contatos.";

            return View();
        }

        public ActionResult Questão()
        {
            ViewBag.Message = "As questões.";

            return View();
        }

        public ActionResult Signup()
        {
            ViewBag.Message = "Introduza as suas credenciais";

            return View();
        }

        public ActionResult Upvote()
        {
            ViewBag.Message = "Upvotes";

            return View();
        }
    }
}