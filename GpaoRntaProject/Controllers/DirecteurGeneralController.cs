using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GpaoRntaProject.Controllers
{
    public class DirecteurGeneralController : Controller
    {
        [Authorize(Roles = "Directeur Général")]
        public ActionResult Index()
        {
            return View();
        }
    }
}