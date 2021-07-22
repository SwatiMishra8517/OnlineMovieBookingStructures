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
    public class CinemasController : Controller
    {
        private CinemaControllerService ccs = new CinemaControllerService();
        private CityControllerService cts = new CityControllerService();

        // GET: Cinemas
        public ActionResult Index()
        {
            List<CinemaViewModel> cms = new List<CinemaViewModel>();
            List<CinemaModel> cinemas = ccs.GetAll();
            foreach (var cinema in cinemas)
            {
                CinemaViewModel c = new CinemaViewModel
                {
                    CinemaId = cinema.CinemaId,
                    Name = cinema.Name,
                    TotalHalls = cinema.TotalHalls,
                    CityId = cinema.CityId,
                };
                cms.Add(c);
            }
            return View(cms);
        }

        // GET: Cinemas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaModel cinema = ccs.GetById((int)id);
            CinemaViewModel c = new CinemaViewModel
            {
                CinemaId = cinema.CinemaId,
                Name = cinema.Name,
                TotalHalls = cinema.TotalHalls,
                CityId = cinema.CityId,
            };
            if (cinema == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        // GET: Cinemas/Create
        public ActionResult Create()
        {

            ViewBag.CityId = new SelectList(cts.GetAll(), "CityId", "Name");
            return View();
        }

        // POST: Cinemas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinemaId,Name,TotalHalls,CityId")] CinemaViewModel cinema)
        {
            if (ModelState.IsValid)
            {
                CinemaModel c = new CinemaModel
                {
                    CinemaId = cinema.CinemaId,
                    Name = cinema.Name,
                    TotalHalls = cinema.TotalHalls,
                    CityId = cinema.CityId,
                };
                ccs.Add(c);
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(cts.GetAll(), "CityId", "Name", cinema.CityId);
            return View(cinema);
        }

        // GET: Cinemas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaModel cinema = ccs.GetById((int)id);
            if (cinema == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(cts.GetAll(), "CityId", "Name", cinema.CityId);
            return View(cinema);
        }

        // POST: Cinemas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinemaId,Name,TotalHalls,CityId")] CinemaViewModel cinema)
        {
            if (ModelState.IsValid)
            {
                CinemaModel c = new CinemaModel
                {
                    CinemaId = cinema.CinemaId,
                    Name = cinema.Name,
                    TotalHalls = cinema.TotalHalls,
                    CityId = cinema.CityId,
                };
                ccs.Update(c.CinemaId, c);
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(cts.GetAll(), "CityId", "Name", cinema.CityId);
            return View(cinema);
        }

        // GET: Cinemas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CinemaModel cinema = ccs.GetById((int)id);
            if (cinema == null)
            {
                return HttpNotFound();
            }
            return View(cinema);
        }

        // POST: Cinemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CinemaModel cinema = ccs.GetById(id);
            ccs.Delete(id);
            return RedirectToAction("Index");
        }

        
    }
}
