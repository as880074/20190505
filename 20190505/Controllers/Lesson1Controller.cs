using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20190505.Controllers
{
    public class Lesson1Controller : Controller
    {
        // GET: Lesson1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexA()
        {
            return View("HelloWord");
        }
        public ActionResult IndexB()
        {
            return View("~/Views/Lesson1/HelloWord.cshtml");
        }
        public string IndexC()
        {
            return "傳回一個字串，一句<h3>string</h3>";
        }
        public ActionResult IndexD()
        {
            return Content("傳回一個字串，一句<h3>Content</h3>");
        }
        public ActionResult IndexE()
        {
            return Redirect("IndexC");
        }
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Redirect("IndexC");
            base.HandleUnknownAction(actionName);
        }
        public ActionResult Index2()
        {
            return View();
            // 產生檢視（View）的時候，搭配「版面配置頁」（類似Web Form的 MasterPage 母版頁面）
            // 自己設定的「版面配置頁」，檔案位於 ~/Views/Shared/_LayoutPage1.cshtml

            // 完成後，可搭配 Index8 一起學習。
        }
        public ActionResult Index3()
        {
            ViewData["A"] = "(1) 字串A 我是ViewData[]";
            ViewBag.B = "(2) 字串B 我是ViewBag";
            TempData["C"] = "(3) 字串C。我是TempData";
            return View();
        }
        public ActionResult Index3A()
        {
            ViewData["XYZ"] = "(1) 字串A 我是ViewData[]";
            ViewBag.XYZ = "(2) 字串B 我是ViewBag";
            return View();
        }
        public ActionResult Index4()
        {
            var UserName = new Models.Class1();
            UserName.UserName = "(4)字串D。我躲在Class1類別 的UserName屬性";
            return View(UserName);
        }
        public ActionResult Index5()
        {
            List<Models.Class1> myList = new List<Models.Class1>
            {
                new Models.Class1{ UserName="(5).字串ASP.NET。" },
                new Models.Class1{ UserName="(6).字串ASP.NET。" },
                new Models.Class1{ UserName="(7).字串ASP.NET。" },
                new Models.Class1{ UserName="(8).字串ASP.NET。" }
                //UserName.UserName = "(4)字串D。我躲在Class1類別 的UserName屬性";
            };
   
            return View(myList);
        }
        public ActionResult Index4A()
        {
            var UserName = new Models.PersonData()
            {
                PersonName = "(4)字串D。我躲在Class1類別 的UserName屬性",
                PersonSex = "男",
                PersonMobile = "0933256222"            
            };           
            return View(UserName);
        }
        public ActionResult Index5A()
        {
            List<Models.PersonData> myList = new List<Models.PersonData>
            {
                new Models.PersonData{ PersonName="王小明", PersonSex = "男",PersonMobile ="0564212288"},
                new Models.PersonData{ PersonName="方大同" , PersonSex = "男",PersonMobile ="0564212288"},
                new Models.PersonData{ PersonName="王八蛋", PersonSex = "男",PersonMobile ="0564212288" },
                new Models.PersonData{ PersonName="林曉菁" , PersonSex = "男",PersonMobile ="0564212288"}
                //UserName.UserName = "(4)字串D。我躲在Class1類別 的UserName屬性";
            };

            return View(myList);
        }
        public ActionResult Index6()
        {
            
            return View();
        }
        public ActionResult Index7()
        {

            return View();
        }
        public ActionResult Index7for()
        {

            return View();
        }
        public ActionResult Index7Request()
        {

            return View();
        }
        public ActionResult Index8()
        {

            return View();
        }
        public ActionResult Index90IsPost()
        {

            return View();
        }
    }
}