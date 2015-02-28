// Kontroler obslugujacy system LifeSpinner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lfspinnerBeta.Controllers
{
    [RequireHttps]
    public class SystemController : Controller
    {
        //
        // GET: /System/

        public string Index()
        {
            return "dziala";
        }

    }
}
