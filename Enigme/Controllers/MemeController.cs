using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enigme.Controllers
{
    public class MemeController : Controller
    {
        //
        // GET: /Meme/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Plopinou()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Plopinou(string email)
        {
            return Json(new { result = "Mamapo/Yagadou" });
        }

        public ActionResult Meuporg()
        {
            return View();
        }

    }
}
