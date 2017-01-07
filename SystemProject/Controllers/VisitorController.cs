//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;


//namespace SystemProject.Controllers
//{
//    public class VisitorController : Controller
//    {
//        private Data.smartshopdbDataContext db = new Data.smartshopdbDataContext();


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult VisitorDetails([Bind(Include =
//        "id,name,email,date_visited")] VisitorController visitorDetail)
//        {
//            if (ModelState.IsValid)
//            {



//                db.visitors.InsertOnSubmit(visitorDetail);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            return View(visitorDetail);
//        }
//        // GET: Visitor
//        public ActionResult VisitorDetails()
//        {
//            return View();
//        }
//    }
//}