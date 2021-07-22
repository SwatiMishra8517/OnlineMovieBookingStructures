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
    public class BookingsController : Controller
    {
        private readonly BookingControllerService bcs = new BookingControllerService();
        private readonly ShowControllerService scs = new ShowControllerService();
        private readonly UserControllerService ucs = new UserControllerService();

        // GET: Bookings
        public ActionResult Index()
        {
            List<BookingViewModel> bList = new List<BookingViewModel>();
            List<BookingModel> bms = bcs.GetAll();
            foreach (var booking in bms)
            {
                BookingViewModel b = new BookingViewModel
                {
                    BookingId = booking.BookingId,
                    NumberOfSeats = booking.NumberOfSeats,
                    Time = booking.Time,
                    Status = booking.Status,
                    ShowId = booking.ShowId,
                    UserId = booking.UserId,
                };
                bList.Add(b);
            }
            return View(bList);
        }

        // GET: Bookings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingModel booking = bcs.GetById((int)id);
            BookingViewModel b = new BookingViewModel
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                ShowId = booking.ShowId,
                UserId = booking.UserId,
            };

            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }

        // GET: Bookings/Create
        public ActionResult Create()
        {

            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId");
            ViewBag.UserId = new SelectList(ucs.GetAll(), "UserId", "Name");
            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingId,NumberOfSeats,Time,Status,UserId,ShowId")] BookingViewModel booking)
        {
            if (ModelState.IsValid)
            {
                BookingModel b = new BookingModel
                {
                    BookingId = booking.BookingId,
                    NumberOfSeats = booking.NumberOfSeats,
                    Time = booking.Time,
                    Status = booking.Status,
                    ShowId = booking.ShowId,
                    UserId = booking.UserId,
                };
                bcs.Add(b);
                return RedirectToAction("Index");
            }

            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", booking.ShowId);
            ViewBag.UserId = new SelectList(ucs.GetAll(), "UserId", "Name", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingModel booking = bcs.GetById((int)id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", booking.ShowId);
            ViewBag.UserId = new SelectList(ucs.GetAll(), "UserId", "Name", booking.UserId);
            BookingViewModel b = new BookingViewModel
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                ShowId = booking.ShowId,
                UserId = booking.UserId,
            };
            return View(b);
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,[Bind(Include = "BookingId,NumberOfSeats,Time,Status,UserId,ShowId")] BookingViewModel booking)
        {
            if (ModelState.IsValid)
            {
                BookingModel b = new BookingModel
                {
                    BookingId = booking.BookingId,
                    NumberOfSeats = booking.NumberOfSeats,
                    Time = booking.Time,
                    Status = booking.Status,
                    ShowId = booking.ShowId,
                    UserId = booking.UserId,
                };
                bcs.Update(id, b);
                return RedirectToAction("Index");
            }
            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", booking.ShowId);
            ViewBag.UserId = new SelectList(ucs.GetAll(), "UserId", "Name", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public ActionResult Delete(int id)
        {
            BookingModel booking = bcs.GetById(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bcs.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
