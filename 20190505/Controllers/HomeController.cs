using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20190505.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.DateTime = DateTime.Now.ToString();
            return View();
        }

        public ActionResult testLab()
        {
            return View();
        }
        public ActionResult Index2()
        {
            Models.Class1 class1 = new Models.Class1();
            class1.UserName = "王八蛋";
            return View(class1);
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
    }
}