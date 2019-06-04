using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _20190505.Models;

namespace _20190505.Controllers
{
    public class PracticeController : Controller
    {
        dbToDoEntities db = new dbToDoEntities();
        // GET: Practice
        public ActionResult Index()
        {
            var todos = db.tToDo.OrderByDescending(m=>m.fDate).ToList();
            return View(todos);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string fTitle, string fImage,DateTime fDate)
        {
            tToDo todo = new tToDo();
            todo.fTitle = fTitle;
            todo.flmage = fImage;
            todo.fDate = fDate;
             db.tToDo.Add(todo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var todo = db.tToDo.Where(m => m.fld == id).FirstOrDefault();
            db.tToDo.Remove(todo);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var todo = db.tToDo.Where(m => m.fld == id).FirstOrDefault();
            return View(todo);
        }
        [HttpPost]
        public ActionResult Edit(int fld, string fTitle, string fImage, DateTime fDate)
        {
            var todo = db.tToDo.Where(m => m.fld == fld).FirstOrDefault();
            todo.fTitle = fTitle;
            todo.flmage = fImage;
            todo.fDate = fDate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}