using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMovieBooking.Models;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Helpers;
using System.Data.Entity.Validation;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.ViewModels;

namespace OnlineMovieBooking.Controllers
{
    [AllowAnonymous]
    public class UserLoginController : Controller
    {
        private readonly UserControllerService ucs = new UserControllerService();
        //string salt = "agftwjd128";
        // GET: UserLogin
        public ActionResult Login()
        {
            if (User.Identity.Name == "admin")
            {
                return RedirectToAction("Index", "Movies");
            }
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Movie");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {

            // user.Password = Encrypt(user.Password);
            //bool isvalidUser = db.Users.Any(m => m.Username == user.Username && m.Password == user.Password);
            if (ModelState.IsValid)
            {

                UserModel u = new UserModel
                {
                    Username = user.Username,
                    Password = user.Password,
                };
                UserModel userDetail = ucs.GetByUserName(u.Username);
                if (userDetail != null)
                {
                    FormsAuthentication.SetAuthCookie(u.Username, false);

                    return RedirectToAction("Home", "UserInterfaceHome");
                }
                else
                {
                    ModelState.AddModelError("", "User doesn't Exists");
                    return View();
                }
            }
            return View();

        }
        /* public string Encrypt(string pwd)
         {
             try
             {
                 byte[] EncDataByte = new byte[pwd.Length];
                 EncDataByte = System.Text.Encoding.UTF8.GetBytes(pwd);
                 string EncryptedData = Convert.ToBase64String(EncDataByte);
                 return EncryptedData;
             }
             catch(Exception ex)
             {
                 throw new Exception("Error in Encode: " + ex.Message);
             }
         }
        */


        public ActionResult SignUp()
        {
            if (User.Identity.Name == "admin")
            {
                return RedirectToAction("Index", "Movies");
            }
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Movie");
            }
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserViewModel user)
        {

            if (ModelState.IsValid)
            {

                UserModel u = new UserModel
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Username = user.Username,
                    MobileNo = user.MobileNo,
                    Email = user.Email,
                    Password = user.Password
                };
                // user.Password = Encrypt(user.Password);
                    ucs.Add(u);
                return RedirectToAction("Login");
            }

            return View();
        }
        public ActionResult Admin()
        {
            if (User.Identity.Name == "admin")
            {
                return RedirectToAction("Index", "Movies");
            }
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Movie");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Admin(UserLoginViewModel user)
        {

            if (user.Username == "admin" && user.Password == "Admin@123")
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                //change the parameters
                return RedirectToAction("Index", "Movies");
            }
            else
            {
                ModelState.AddModelError("", "Admin credentials are incorrect");
                return View();
            }

        }
        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("/UserLogin/Login");
        }
    }
}