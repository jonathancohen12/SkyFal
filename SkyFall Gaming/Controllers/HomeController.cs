using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyFall_Gaming.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Teams()
        {
            ViewBag.Message = "Come meet the Leagues Team Members";

            return View();
        }
        public ActionResult TheTeam()
        {
            ViewBag.Message = "Come meet the team";

            return View();
        }
          }
}