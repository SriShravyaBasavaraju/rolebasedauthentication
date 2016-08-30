using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleBasedAuthentication.Controllers
{
    public class AdvisorController : Controller
    {
        // GET: Advisor
        [Authorize(Roles = "Advisor")]
        public ActionResult Index()
        {
            return View();
        }
    }
}