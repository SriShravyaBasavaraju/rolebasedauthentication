using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoleBasedAuthentication.Controllers
{
    public class AssistantController : Controller
    {
        // GET: Assistant
        [Authorize(Roles = "Assistant")]
        public ActionResult Index()
        {
            return View();
        }
    }
}