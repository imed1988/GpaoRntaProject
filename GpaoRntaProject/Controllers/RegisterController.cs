using GpaoRntaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GpaoRntaProject.Controllers
{
    public class RegisterController : Controller
    {
        DBEntities db = new DBEntities();

        // GET: Register
        public ActionResult Index()
        {
            
            return View();
        }


      
        public JsonResult InsertUser(SiteUser user)
        {
            db.SiteUser.Add(user);
            db.SaveChanges();
            return Json("success", JsonRequestBehavior.AllowGet);
        }




    }
}