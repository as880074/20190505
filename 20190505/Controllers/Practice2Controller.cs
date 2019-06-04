using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20190505.Models;

namespace _20190505.Controllers
{
    public class Practice2Controller : Controller
    {
        // GET: Practice2
        public ActionResult Index()
        {
            return View();
        }
        public string ShowArray()
        {
            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            int sum = 0;
            foreach (var m in score)
            {
                show += m + ",";
                sum += m;
            }
            show += "</br>";
            show += "總和 = " + sum;
            return show;
        }
        public string ShowImage()
        {
            //~\\images\\
            string show = "";
            for (int i = 1; i <= 8; i++)
            {
                show += "<img src =\"../images/" + i + ".jpg\" width = \"150\"></img>";
                //show += "</br>";
            }
            return show;
        }
        public string ShowImageIndex(int index)
        {
            string show = "";
            show += "<img src =\"../images/" + index + ".jpg\"></img>";

            return show;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            ViewBag.PId = product.PId;
            ViewBag.PName = product.PName;
            ViewBag.Price = product.Price;
            return View();
        }
    }
}