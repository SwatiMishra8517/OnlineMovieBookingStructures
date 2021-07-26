using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.Models;
using OnlineMovieBooking.ViewModels;

namespace OnlineMovieBooking.Controllers
{
    [Authorize]
    public class CinemaHallsController : Controller
    {
        private CinemaHallControllerService chs = new CinemaHallControllerService();

        // GET: CinemaHalls
        public ActionResult Index()
        {
            List<CinemaHallViewModel> chvs = new List<CinemaHallViewModel>();
            List<CinemaHallModel> cinemaHalls = chs.GetAll();
            foreach (var cinemaHall in cinemaHalls)
            {
                CinemaHallViewModel ch = new CinemaHallViewModel
                {
                    CinemaHallId = cinemaHall.CinemaHallId,
                    Name = cinemaHall.Name,
                };
                chvs.Add(ch);
            }
            return View(chvs);
        }

        // GET: CinemaHalls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaHallModel cinemaHall = chs.GetById((int)id);
            CinemaHallViewModel ch = new CinemaHallViewModel
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
            };
            if (cinemaHall == null)
            {
                return HttpNotFound();
            }
            return View(ch);
        }

        // GET: CinemaHalls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaHalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinemaHallId,Name,TotalSeats,CinemaId")] CinemaHallViewModel cinemaHall)
        {
            if (ModelState.IsValid)
            {
                CinemaHallModel ch = new CinemaHallModel
                {
                    CinemaHallId = cinemaHall.CinemaHallId,
                    Name = cinemaHall.Name,
                };
                chs.Add(ch);
                return RedirectToAction("Index");
            }

            return View(cinemaHall);
        }

        // GET: CinemaHalls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaHallModel cinemaHall = chs.GetById((int)id);
            if (cinemaHall == null)
            {
                return HttpNotFound();
            }
            return View(cinemaHall);
        }

        // POST: CinemaHalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinemaHallId,Name,TotalSeats,CinemaId")] CinemaHallViewModel cinemaHall)
        {
            if (ModelState.IsValid)
            {
                CinemaHallModel ch = new CinemaHallModel
                {
                    CinemaHallId = cinemaHall.CinemaHallId,
                    Name = cinemaHall.Name,
                };
                chs.Update(ch.CinemaHallId, ch);
                return RedirectToAction("Index");
            }
            return View(cinemaHall);
        }

        // GET: CinemaHalls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaHallModel cinemaHall = chs.GetById((int)id);
            if (cinemaHall == null)
            {
                return HttpNotFound();
            }
            CinemaHallViewModel ch = new CinemaHallViewModel
            {
                CinemaHallId = cinemaHall.CinemaHallId,
                Name = cinemaHall.Name,
            };
            return View(ch);
        }

        // POST: CinemaHalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CinemaHallModel cinemaHall = chs.GetById(id);
            chs.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
