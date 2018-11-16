using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GpaoRntaProject.Controllers
{
    public class AdminstrateurController : Controller
    {
        [Authorize (Roles ="Administrateur")]
        public ActionResult Index()
        {
            return View();
        }
    }
}