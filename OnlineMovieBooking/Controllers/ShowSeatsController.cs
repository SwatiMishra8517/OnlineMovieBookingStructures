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
    [Authorize]
    public class ShowSeatsController : Controller
    {
        private readonly ShowSeatControllerService sscs = new ShowSeatControllerService();
        private readonly ShowControllerService scs = new ShowControllerService();

        // GET: ShowSeats
        public ActionResult Index()
        {
            List<ShowSeatModel> ssms = sscs.GetAll();
            List<ShowSeatViewModel> sList = new List<ShowSeatViewModel>();
            foreach (var showSeat in ssms)
            {
                ShowSeatViewModel ss = new ShowSeatViewModel();
                ss.ShowId = showSeat.ShowId;
                ss.ShowSeatId = showSeat.ShowSeatId;
                if (showSeat.Status == "R")
                {
                    ss.Status = true;
                }
                else
                {
                    ss.Status = false;
                }

                sList.Add(ss);
            }

            return View(sList); 
        }

        // GET: ShowSeats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowSeatModel showSeat = sscs.GetById((int)id);
            if (showSeat == null)
            {
                return HttpNotFound();
            }
            return View(showSeat);
        }

        // GET: ShowSeats/Create
        public ActionResult Create()
        {

            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId");
            return View();
        }

        // POST: ShowSeats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowSeatId,Status,Price,CinemaSeatId,ShowId,BookingId")] ShowSeatViewModel showSeat)
        {

            if (ModelState.IsValid)
            {
                ShowSeatModel s = new ShowSeatModel();
                s.ShowId = showSeat.ShowId;
                s.ShowSeatId = showSeat.ShowSeatId;
                if (showSeat.Status == true)
                {
                    s.Status = "R";
                }
                else
                {
                    s.Status = "N";
                }
                
                sscs.Add(s);
                return RedirectToAction("Index");
            }

            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }

        // GET: ShowSeats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowSeatModel showSeat = sscs.GetById((int)id);
            if (showSeat == null)
            {
                return HttpNotFound();
            }
            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }

        // POST: ShowSeats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowSeatId,Status,Price,CinemaSeatId,ShowId,BookingId")] ShowSeatViewModel showSeat)
        {
            if (ModelState.IsValid)
            {
                ShowSeatModel s = new ShowSeatModel();
                s.ShowId = showSeat.ShowId;
                s.ShowSeatId = showSeat.ShowSeatId;
                if (showSeat.Status == true)
                {
                    s.Status = "R";
                }
                else
                {
                    s.Status = "N";
                }
                sscs.Update(showSeat.ShowId, s);
                return RedirectToAction("Index");
            }
            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }

        // GET: ShowSeats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowSeatModel showSeat = sscs.GetById((int)id);
            ShowSeatModel s = new ShowSeatModel
            {
                ShowSeatId = showSeat.ShowSeatId,
                Status = showSeat.Status,
                ShowId = showSeat.ShowId,
            };
            if (showSeat == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: ShowSeats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShowSeatModel showSeat = sscs.GetById(id);
            sscs.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
