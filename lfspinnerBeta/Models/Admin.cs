using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lfspinnerBeta.Models
{
    public class Admin
    {
        public string login { get; set; }
        public string pass { get; set; }
        public string rola { get; set; }
    }

    public class User
    {
        public string Email { get; set; }
        public string UserName { get; set; }

    }
}