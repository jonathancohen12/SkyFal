using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyFall_Gaming.Controllers
{
    public class ApplicationController : Controller
    {
    
        public ActionResult Caster()
        {
            
            return View();
        }
        public ActionResult Staff()
        {

            return View();
        }
        public ActionResult Recruiter()
        {

            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult StaffReponse()
        {

            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult CasterReponse()
        {

            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult RecruiterReponse()
        {

            return View();
        }

    }
}
