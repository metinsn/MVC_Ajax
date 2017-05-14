using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Ajax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name, string pass)
        {
            if (name == "yavuz" && pass == "1234")
            {
                return Json(new { success = true, mesaj = "Giriş Başarılı" });
            }
            else
            {
                return Json(new { success = false, mesaj = "Hatalı Giriş" });
            }
        }
    }
}