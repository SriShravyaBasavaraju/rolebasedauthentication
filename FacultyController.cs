using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleBasedAuthentication.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        [Authorize(Roles = "Faculty")]
        public ActionResult Index()
        {
            return View();
        }
    }
}