using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.ViewModels;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class CinemaSeatsController : Controller
    {
        private CinemaSeatControllerService css = new CinemaSeatControllerService();
        private CinemaHallControllerService chs = new CinemaHallControllerService();

        // GET: CinemaSeats
        public ActionResult Index()
        {
            var cinemaSeats = css.GetAll();
            List<CinemaSeatViewModel> csms = new List<CinemaSeatViewModel>();
            foreach (var cinemaSeat in cinemaSeats)
            {
                CinemaSeatViewModel cs = new CinemaSeatViewModel
                {
                    CinemaSeatId = cinemaSeat.CinemaSeatId,
                    SeatNumber = cinemaSeat.SeatNumber,
                    Type = cinemaSeat.Type,
                    CinemaHallId = cinemaSeat.CinemaHallId,
                };
                csms.Add(cs);
            }
            return View(csms);
        }

        // GET: CinemaSeats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaSeatModel cinemaSeat = css.GetById((int)id);
            CinemaSeatViewModel cs = new CinemaSeatViewModel
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId,
            };
            if (cinemaSeat == null)
            {
                return HttpNotFound();
            }
            return View(cs);
        }

        // GET: CinemaSeats/Create
        public ActionResult Create()
        { 
            ViewBag.CinemaHallId = new SelectList(chs.GetAll(), "CinemaHallId", "Name");
            return View();
        }

        // POST: CinemaSeats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinemaSeatId,SeatNumber,Type,CinemaHallId")] CinemaSeatViewModel cinemaSeat)
        {
            if (ModelState.IsValid)
            {
                CinemaSeatModel cs = new CinemaSeatModel
                {
                    CinemaSeatId = cinemaSeat.CinemaSeatId,
                    SeatNumber = cinemaSeat.SeatNumber,
                    Type = cinemaSeat.Type,
                    CinemaHallId = cinemaSeat.CinemaHallId,
                };

                css.Add(cs);
                return RedirectToAction("Index");
            }

            ViewBag.CinemaHallId = new SelectList(chs.GetAll(), "CinemaHallId", "Name", cinemaSeat.CinemaHallId);
            return View(cinemaSeat);
        }

        // GET: CinemaSeats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaSeatModel cinemaSeat = css.GetById((int)id);
            if (cinemaSeat == null)
            {
                return HttpNotFound();
            }
            var cinemahalls = chs.GetAll().Select(
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
        public ActionResult Edit([Bind(Include = "CinemaSeatId,SeatNumber,Type,CinemaHallId")] CinemaSeatViewModel cinemaSeat)
        {
            if (ModelState.IsValid)
            {
                CinemaSeatModel cs = new CinemaSeatModel
                {
                    CinemaSeatId = cinemaSeat.CinemaSeatId,
                    SeatNumber = cinemaSeat.SeatNumber,
                    Type = cinemaSeat.Type,
                    CinemaHallId = cinemaSeat.CinemaHallId,
                };

                css.Update(cs.CinemaSeatId,cs);
                return RedirectToAction("Index");
            }
            ViewBag.CinemaHallId = new SelectList(chs.GetAll(), "CinemaHallId", "Name", cinemaSeat.CinemaHallId);
            return View(cinemaSeat);
        }

        // GET: CinemaSeats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaSeatModel cinemaSeat = css.GetById((int)id);
            if (cinemaSeat == null)
            {
                return HttpNotFound();
            }
            CinemaSeatViewModel cs = new CinemaSeatViewModel
            {
                CinemaSeatId = cinemaSeat.CinemaSeatId,
                SeatNumber = cinemaSeat.SeatNumber,
                Type = cinemaSeat.Type,
                CinemaHallId = cinemaSeat.CinemaHallId,
            };

            return View(cs);
        }

        // POST: CinemaSeats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            css.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
