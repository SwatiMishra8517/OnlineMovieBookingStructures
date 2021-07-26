using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.ViewModels;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    [Authorize]
    public class MoviesController : Controller
    {
        private MovieControllerService mcs = new MovieControllerService();

        // GET: Movies
        public ActionResult Index()
        {
            List<MovieModel> movies = mcs.GetAll();
            List<MovieViewModel> mms = new List<MovieViewModel>();
            foreach (var movie in movies)
            {
                MovieViewModel m = new MovieViewModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Language = movie.Language,
                    Genre = movie.Genre,
                    Duration = movie.Duration,
                    Description = movie.Description,
                    ReleaseDate = movie.ReleaseDate,
                };
                mms.Add(m);
            }
            return View(mms);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieModel movie = mcs.GetById((int)id);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
            };
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,Name,Language,Genre,Duration,Description,ReleaseDate")] MovieViewModel movie)
        {
            if (ModelState.IsValid)
            {

                MovieModel m = new MovieModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Language = movie.Language,
                    Genre = movie.Genre,
                    Duration = movie.Duration,
                    Description = movie.Description,
                    ReleaseDate = movie.ReleaseDate,
                };
                mcs.Add(m);
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieModel movie = mcs.GetById((int)id);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
            };
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,Name,Language,Genre,Duration,Description,ReleaseDate")] MovieViewModel movie)
        {
            if (ModelState.IsValid)
            {
                MovieModel m = new MovieModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Language = movie.Language,
                    Genre = movie.Genre,
                    Duration = movie.Duration,
                    Description = movie.Description,
                    ReleaseDate = movie.ReleaseDate,
                };
                mcs.Update(m.MovieId, m);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieModel movie = mcs.GetById((int)id);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Language = movie.Language,
                Genre = movie.Genre,
                Duration = movie.Duration,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
            };
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(m);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mcs.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
