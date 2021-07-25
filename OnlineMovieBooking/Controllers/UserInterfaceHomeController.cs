using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OnlineMovieBooking.ViewModels;

namespace OnlineMovieBooking.Controllers
{
    public class UserInterfaceHomeController : Controller
    {
        // GET: UserInterface
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/UserLogin/Login");
        }
    }
}