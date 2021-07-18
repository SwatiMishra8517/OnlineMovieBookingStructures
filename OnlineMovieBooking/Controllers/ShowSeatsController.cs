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
    public class ShowSeatsController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: ShowSeats
        public ActionResult Index()
        {
            var showSeats = db.ShowSeats.Include(s => s.Booking).Include(s => s.CinemaSeat).Include(s => s.Show);
            return View(showSeats.ToList());
        }

        // GET: ShowSeats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowSeat showSeat = db.ShowSeats.Find(id);
            if (showSeat == null)
            {
                return HttpNotFound();
            }
            return View(showSeat);
        }

        // GET: ShowSeats/Create
        public ActionResult Create()
        {
            ViewBag.BookingId = new SelectList(db.Bookings, "BookingId", "Status");
            var cinemaseats = db.CinemaSeats.Select(
            c => new
            {
                CinemaSeatId = c.CinemaSeatId,
                Name = c.SeatNumber + "-" + c.CinemaHall.Cinema.Name + " " +c.CinemaHall.Cinema.City.Name + " (" + c.CinemaHall.Name + ")"
            });
            ViewBag.CinemaSeatId = new SelectList(cinemaseats, "CinemaSeatId", "Name");

            ViewBag.ShowId = new SelectList(db.Shows, "ShowId", "ShowId");
            return View();
        }

        // POST: ShowSeats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowSeatId,Status,Price,CinemaSeatId,ShowId,BookingId")] ShowSeat showSeat)
        {
            if (ModelState.IsValid)
            {
                db.ShowSeats.Add(showSeat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookingId = new SelectList(db.Bookings, "BookingId", "Status", showSeat.BookingId);
            ViewBag.CinemaSeatId = new SelectList(db.CinemaSeats, "CinemaSeatId", "SeatNumber", showSeat.CinemaSeatId);
            ViewBag.ShowId = new SelectList(db.Shows, "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }

        // GET: ShowSeats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowSeat showSeat = db.ShowSeats.Find(id);
            if (showSeat == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookingId = new SelectList(db.Bookings, "BookingId", "Status", showSeat.BookingId);
            ViewBag.CinemaSeatId = new SelectList(db.CinemaSeats, "CinemaSeatId", "SeatNumber", showSeat.CinemaSeatId);
            ViewBag.ShowId = new SelectList(db.Shows, "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }

        // POST: ShowSeats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowSeatId,Status,Price,CinemaSeatId,ShowId,BookingId")] ShowSeat showSeat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showSeat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookingId = new SelectList(db.Bookings, "BookingId", "Status", showSeat.BookingId);
            ViewBag.CinemaSeatId = new SelectList(db.CinemaSeats, "CinemaSeatId", "SeatNumber", showSeat.CinemaSeatId);
            ViewBag.ShowId = new SelectList(db.Shows, "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }

        // GET: ShowSeats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowSeat showSeat = db.ShowSeats.Find(id);
            if (showSeat == null)
            {
                return HttpNotFound();
            }
            return View(showSeat);
        }

        // POST: ShowSeats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShowSeat showSeat = db.ShowSeats.Find(id);
            db.ShowSeats.Remove(showSeat);
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
