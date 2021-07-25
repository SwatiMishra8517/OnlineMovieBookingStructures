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
    public class ShowsController : Controller
    {
        private ShowControllerService scs = new ShowControllerService();
        private MovieControllerService mvs = new MovieControllerService();
        private CinemaHallControllerService ccs = new CinemaHallControllerService();

        // GET: Shows
        public ActionResult Index()
        {
            List<ShowModel> shows = scs.GetAll();
            List<ShowViewModel> sms = new List<ShowViewModel>();
            foreach (var show in shows)
            {
                var movie = mvs.GetById(show.MovieId);
                MovieViewModel m = new MovieViewModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Language = movie.Language,
                    Genre = movie.Genre,
                    ReleaseDate = movie.ReleaseDate,
                    Duration = movie.Duration,
                    Description = movie.Description,
                };
                var cinema = ccs.GetById(show.CinemaHallId);
                CinemaHallViewModel c = new CinemaHallViewModel
                {
                    CinemaHallId = cinema.CinemaHallId,
                    Name = cinema.Name
                };
                ShowViewModel s = new ShowViewModel
                {
                    ShowId = show.ShowId,
                    Date = show.Date,
                    StartTime = show.StartTime,
                    EndTime = show.EndTime,
                    CinemaHallId = show.CinemaHallId,
                    MovieId = show.MovieId,
                    Movie = m,
                    CinemaHall = c
                };
                sms.Add(s);
            }
            return View(sms);
        }

        // GET: Shows/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowModel show = scs.GetById((int)id);
            var movie = mvs.GetById(show.MovieId);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate,
                Duration = movie.Duration,
                Description = movie.Description,
            };
            var cinema = ccs.GetById(show.CinemaHallId);
            CinemaHallViewModel c = new CinemaHallViewModel
            {
                CinemaHallId = cinema.CinemaHallId,
                Name = cinema.Name
            };
            ShowViewModel s = new ShowViewModel
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                CinemaHallId = show.CinemaHallId,
                MovieId = show.MovieId,
                Movie = m,
                CinemaHall = c
            };
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // GET: Shows/Create
        public ActionResult Create()
        {
            ViewBag.CinemaHallId = new SelectList(ccs.GetAll(), "CinemaHallId", "Name");
            ViewBag.MovieId = new SelectList(mvs.GetAll(), "MovieId", "Name");
            return View();
        }

        // POST: Shows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowId,Date,StartTime,EndTime,CinemaHallId,MovieId")] ShowViewModel show)
        {
            if (ModelState.IsValid)
            {
                ShowModel s = new ShowModel
                {
                    ShowId = show.ShowId,
                    Date = show.Date,
                    StartTime = show.StartTime,
                    EndTime = show.EndTime,
                    CinemaHallId = show.CinemaHallId,
                    MovieId = show.MovieId
                };
                return RedirectToAction("Index");
            }
            ViewBag.CinemaHallId = new SelectList(ccs.GetAll(), "CinemaHallId", "Name", show.CinemaHallId);
            ViewBag.MovieId = new SelectList(mvs.GetAll(), "MovieId", "Name", show.MovieId);
            return View(show);
        }

        // GET: Shows/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowModel show = scs.GetById((int)id);
            if (show == null)
            {
                return HttpNotFound();
            }
            ShowViewModel s = new ShowViewModel
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                CinemaHallId = show.CinemaHallId,
                MovieId = show.MovieId
            };
            ViewBag.CinemaHallId = new SelectList(ccs.GetAll(), "CinemaHallId", "Name", show.CinemaHallId);
            ViewBag.MovieId = new SelectList(mvs.GetAll(), "MovieId", "Name", show.MovieId);
            return View(s);
        }

        // POST: Shows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowId,Date,StartTime,EndTime,CinemaHallId,MovieId")] ShowViewModel show)
        {
            if (ModelState.IsValid)
            {
                ShowModel s = new ShowModel
                {
                    ShowId = show.ShowId,
                    Date = show.Date,
                    StartTime = show.StartTime,
                    EndTime = show.EndTime,
                    CinemaHallId = show.CinemaHallId,
                    MovieId = show.MovieId
                };
                scs.Update(s.ShowId, s);
                return RedirectToAction("Index");
            }
            ViewBag.CinemaHallId = new SelectList(ccs.GetAll(), "CinemaHallId", "Name", show.CinemaHallId);
            ViewBag.MovieId = new SelectList(mvs.GetAll(), "MovieId", "Name", show.MovieId);
            return View(show);
        }

        // GET: Shows/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowModel show = scs.GetById((int)id);
            var movie = mvs.GetById(show.MovieId);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                ReleaseDate = movie.ReleaseDate,
                Duration = movie.Duration,
                Description = movie.Description,
            };
            var cinema = ccs.GetById(show.CinemaHallId);
            CinemaHallViewModel c = new CinemaHallViewModel
            {
                CinemaHallId = cinema.CinemaHallId,
                Name = cinema.Name
            };
            ShowViewModel s = new ShowViewModel
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                CinemaHallId = show.CinemaHallId,
                MovieId = show.MovieId,
                Movie = m,
                CinemaHall = c
            };
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: Shows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            scs.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
