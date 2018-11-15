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
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddOrEdit()
        {
            return AddOrEdit();
        }


        //[HttpPost]
        //public ActionResult AddOrEdit(SiteUser users)
        //{
        //    return View();
        //}



        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            SiteUser userModel = new SiteUser();
            return View(userModel);

        }

        [HttpPost]
        public ActionResult AddOrEdit(SiteUser user)
        {
            using (DBEntities dbmodel = new DBEntities())
            {
                dbmodel.SiteUser.Add(user);
                dbmodel.SaveChanges();
            }

            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Index", new SiteUser());
        }

    }
}