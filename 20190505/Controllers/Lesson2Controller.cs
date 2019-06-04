using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _20190505.Controllers
{
    public class Lesson2Controller : Controller
    {
        // GET: Lesson2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index10()
        {
            return View();
        }
        public ActionResult Index10BeginForm()
        {
            return View();
        }
        public ActionResult Index11Create()
        {   // 搭配 Class1，做出新增（Create）的檢視畫面
            return View();
        }

        [ValidateAntiForgeryToken]   // 搭配檢視畫面（View）的Razor表單裡面，「@Html.AntiForgeryToken()」這句話以避免CSRF攻擊！！
        [HttpPost, ActionName("Index11Create")]    // ***重點！！刪除這一句話，會出錯！！***  完整寫法 [AcceptVerbs(HttpVerbs.Post)]
        public string Index11Create(Models.Class1 class1)
        {   // 搭配 Class1，做出新增（Create）功能
            try
            {
                if (!ModelState.IsValid)   // 驗證（Validation）。預計到「第五節課」會講到
                {
                    return "NOT ModelState.IsValid";
                }
                return "成功！！......您剛剛輸入的 UserName是：<font color=blue>" + class1.UserName + "</font>";
            }
            catch
            {
                return "Exception：失敗";
            }
        }
    }
}