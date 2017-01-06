using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemProject.Models;

namespace SystemProject.Controllers
{
    public class UserController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
            {
                var context = new ApplicationDbContext();
                var username = User.Identity.Name;

                if (!string.IsNullOrEmpty(username))
                {
                    var user = context.Users.SingleOrDefault(u => u.UserName == username);
                    string fullName = string.Concat(new string[] { user.FullName });

                    ViewData.Add("UserName", User.Identity.Name);
                }
            }
            base.OnActionExecuted(filterContext);
        }

        public UserController()
        { }
    }
}
