using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwitterPL.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Logon()
        {
            return View();
        }
    }
}