using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.Models;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.ViewModels;

namespace OnlineMovieBooking.Controllers
{
    [Authorize(Users = "admin")]
    public class UsersController : Controller
    {
        private readonly UserControllerService ucs = new UserControllerService();

        // GET: Users
        public ActionResult Index()
        {
            List<UserViewModel> uList = new List<UserViewModel>();
            List<UserModel> ums = ucs.GetAll();
            foreach (var user in ums)
            {
                UserViewModel u = new UserViewModel
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Username = user.Username,
                    MobileNo = user.MobileNo,
                    Email = user.Email,
                    Password = user.Password
                };
                uList.Add(u);
            }
            return View(uList);
        }

        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModel user = ucs.GetById((int)id);
            UserViewModel u = new UserViewModel
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(u);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,Name,Username,MobileNo,Email,Password")] UserViewModel user)
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
                ucs.Add(u);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModel user = ucs.GetById((int)id);
            if (user == null)
            {
                return HttpNotFound();
            }
            UserViewModel u = new UserViewModel
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            return View(u);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,Name,Username,MobileNo,Email,Password")] UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(user).State = EntityState.Modified;
                UserModel u = new UserModel
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Username = user.Username,
                    MobileNo = user.MobileNo,
                    Email = user.Email,
                    Password = user.Password
                };
                ucs.Update(user.UserId, u);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModel user = ucs.GetById((int)id);
            UserViewModel u = new UserViewModel
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                MobileNo = user.MobileNo,
                Email = user.Email,
                Password = user.Password
            };
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(u);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserModel user = ucs.GetById(id);
            ucs.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
