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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
        [Authorize]
        public ActionResult Main()
        {

            ViewBag.Categories = GetCategoriesSelectList();
            return View();
           
        }


        private SelectList GetCategoriesSelectList()
        {
             return new SelectList(Post.getCategories(), "category_ID" , "category_name" , "category" , 1 );
        }

     
    }
}