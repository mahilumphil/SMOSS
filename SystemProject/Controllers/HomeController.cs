using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SystemProject.Models;

namespace SystemProject.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {

            return View();
        }

        [Authorize]
        public ActionResult Main()
        {

            return View();
           
        }


     

     
    }
}