using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SystemProject.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        [Authorize]
        public ActionResult VisitorView()
        {
            return View();
        }

        [Authorize]
        public ActionResult Pages()
        {
            return View();
        }

    }
}