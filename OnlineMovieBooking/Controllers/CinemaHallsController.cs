using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.Context;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class CinemaHallsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: CinemaHalls
        public ActionResult Index()
        {
            var cinemaHalls = db.CinemaHalls.Include(c => c.Cinema);
            return View(cinemaHalls.ToList());
        }

        // GET: CinemaHalls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaHall cinemaHall = db.CinemaHalls.Find(id);
            if (cinemaHall == null)
            {
                return HttpNotFound();
            }
            return View(cinemaHall);
        }

        // GET: CinemaHalls/Create
        public ActionResult Create()
        {
            var cinemas = db.Cinemas.Select(
            c => new
            {
                CinemaId = c.CinemaId,
                Name = c.Name + "-" + c.City.Name
            });
            ViewBag.CinemaId = new SelectList(cinemas, "CinemaId", "Name");
            return View();
        }

        // POST: CinemaHalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinemaHallId,Name,TotalSeats,CinemaId")] CinemaHall cinemaHall)
        {
            if (ModelState.IsValid)
            {
                db.CinemaHalls.Add(cinemaHall);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "Name", cinemaHall.CinemaId);
            return View(cinemaHall);
        }

        // GET: CinemaHalls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaHall cinemaHall = db.CinemaHalls.Find(id);
            if (cinemaHall == null)
            {
                return HttpNotFound();
            }
            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "Name", cinemaHall.CinemaId);
            return View(cinemaHall);
        }

        // POST: CinemaHalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinemaHallId,Name,TotalSeats,CinemaId")] CinemaHall cinemaHall)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinemaHall).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CinemaId = new SelectList(db.Cinemas, "CinemaId", "Name", cinemaHall.CinemaId);
            return View(cinemaHall);
        }

        // GET: CinemaHalls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaHall cinemaHall = db.CinemaHalls.Find(id);
            if (cinemaHall == null)
            {
                return HttpNotFound();
            }
            return View(cinemaHall);
        }

        // POST: CinemaHalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CinemaHall cinemaHall = db.CinemaHalls.Find(id);
            db.CinemaHalls.Remove(cinemaHall);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
