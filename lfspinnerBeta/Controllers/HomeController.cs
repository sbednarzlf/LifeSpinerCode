using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lfspinnerBeta.Controllers
{
    
    //[RequireHttps]
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }

        //
        // GET: /Home/Registration
       
        public ActionResult Registration()
        {

            return RedirectToAction("Register", "Account");
            //return View("Registration");
        }


        //
        // GET: /Home/Login
        
        public ActionResult Login()
        {
            return RedirectToAction("Login", "Account");
            //return View("Login");
        }


        //
        // GET: /Home/Lost
        
        public ActionResult Lost()
        {
            return RedirectToAction("ForgotPassword", "Account");
           // return View("Lost");
        }
    }
}