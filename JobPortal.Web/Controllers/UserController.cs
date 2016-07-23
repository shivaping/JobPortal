using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobPortal.Web.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewSignUp()
        {
            return PartialView("_SignUp");
        }
        [HttpPost]
        public ActionResult SignUp()
        {
            return RedirectToAction("Index");
        }
        public ActionResult ViewLogin()
        {
            return PartialView("_Login");
        }
        [HttpPost]
        public ActionResult Login()
        {
            return RedirectToAction("Index");
        }
    }
}
