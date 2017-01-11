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
        public ActionResult VisitorView()
        {
            return View();
        }

        public ActionResult Pages()
        {
            return View();
        }

    }
}