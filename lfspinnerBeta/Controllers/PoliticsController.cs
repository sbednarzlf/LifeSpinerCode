// Kontroler do Obslugi regulaminow, umow itp 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lfspinnerBeta.Controllers
{
    [RequireHttps]
    public class PoliticsController : Controller
    {
        //
        // GET: /Politics/

        public ActionResult Index() // -> wybor dokumentu do odczytu
        {
            return View();
        }


        //
        // GET: /Politics/Cookie

        public ActionResult Cookie()
        {
            return View();
        }


        //
        // GET: /Politics/Regulations

        public ActionResult Regulations()
        {
            return View();
        }

        //
        // GET: /Politics/PersonalData

        public ActionResult PersonalData()
        {
            return View();
        }

          //
        // GET: /Politics/PrivacyPolicy

        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        
    }
}
