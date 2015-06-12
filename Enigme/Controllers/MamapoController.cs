using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enigme.Controllers
{
    public class MamapoController : Controller
    {
        //
        // GET: /Mamapo/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Yagadou()
        {
            return View();
        }

        public ActionResult Woukikikaka()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Woukikikaka(string email)
        {
            return Json(new { result = "Mamapo/Lol" });
        }

        public ActionResult Lol()
        {
            return View();
        }

        public ActionResult Asciiiii()
        {
            return View();
        }
    }
}
