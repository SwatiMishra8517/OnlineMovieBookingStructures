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
    public class CinemaSeatsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: CinemaSeats
        public ActionResult Index()
        {
            var cinemaSeats = db.CinemaSeats.Include(c => c.CinemaHall);
            return View(cinemaSeats.ToList());
        }

        // GET: CinemaSeats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaSeat cinemaSeat = db.CinemaSeats.Find(id);
            if (cinemaSeat == null)
            {
                return HttpNotFound();
            }
            return View(cinemaSeat);
        }

        // GET: CinemaSeats/Create
        public ActionResult Create()
        {
            ViewBag.CinemaHallId = new SelectList(db.CinemaHalls, "CinemaHallId", "Name");
            return View();
        }

        // POST: CinemaSeats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinemaSeatId,SeatNumber,Type,CinemaHallId")] CinemaSeat cinemaSeat)
        {
            if (ModelState.IsValid)
            {
                db.CinemaSeats.Add(cinemaSeat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CinemaHallId = new SelectList(db.CinemaHalls, "CinemaHallId", "Name", cinemaSeat.CinemaHallId);
            return View(cinemaSeat);
        }

        // GET: CinemaSeats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaSeat cinemaSeat = db.CinemaSeats.Find(id);
            if (cinemaSeat == null)
            {
                return HttpNotFound();
            }
            var cinemahalls = db.CinemaHalls.Select(
            c => new
            {
                CinemaHallId = c.CinemaHallId,
                Name = c.Cinema.Name + "-" + c.Cinema.City.Name + " (" + c.Name + ")"
            });
            ViewBag.CinemaHallId = new SelectList(cinemahalls, "CinemaHallId", "Name", cinemaSeat.CinemaHallId);
            return View(cinemaSeat);
        }

        // POST: CinemaSeats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinemaSeatId,SeatNumber,Type,CinemaHallId")] CinemaSeat cinemaSeat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinemaSeat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CinemaHallId = new SelectList(db.CinemaHalls, "CinemaHallId", "Name", cinemaSeat.CinemaHallId);
            return View(cinemaSeat);
        }

        // GET: CinemaSeats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaSeat cinemaSeat = db.CinemaSeats.Find(id);
            if (cinemaSeat == null)
            {
                return HttpNotFound();
            }
            return View(cinemaSeat);
        }

        // POST: CinemaSeats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CinemaSeat cinemaSeat = db.CinemaSeats.Find(id);
            db.CinemaSeats.Remove(cinemaSeat);
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
