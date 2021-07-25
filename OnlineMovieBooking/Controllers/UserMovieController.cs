using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using OnlineMovieBooking.ControllerService;
using OnlineMovieBooking.ViewModels;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.Controllers
{
    public class MovieController : Controller
    {
        private MovieControllerService mcs = new MovieControllerService();
        private FeedbackControllerService fcs = new FeedbackControllerService();
        // GET: Movie
        public ActionResult Index()
        {
            List<MovieViewModel> movies = new List<MovieViewModel>();
            IEnumerable<MovieModel> ml = mcs.GetAll();
            foreach(var movie in ml)
            {
                var m = new MovieViewModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Language = movie.Language,
                    Genre = movie.Genre,
                    Duration = movie.Duration,
                    Description = movie.Description,
                    ReleaseDate = movie.ReleaseDate,
                    
                };
                movies.Add(m);
            }
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            MovieModel movie = mcs.GetById(id);
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
            return View(m);
        }
        public ActionResult FeedBack(int? id)
        {
            List<FeedbackModel> feedbacks = fcs.GetByMovieId((int)id);
            List<FeedbackViewModel> feeds = new List<FeedbackViewModel>();
            foreach(var f in feedbacks)
            {
                FeedbackViewModel df = new FeedbackViewModel();
                df.FeedbackId = f.FeedbackId;
                df.Review = f.Review;
                df.UserId = f.UserId;
                df.MovieId = f.MovieId;
                feeds.Add(df);
            }
            return View(feeds);
        }
        public ActionResult AddFeedBack()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFeedBack(FeedbackViewModel feedback)
        {
            if (ModelState.IsValid)
            {
                FeedbackModel f = new FeedbackModel
                {
                    FeedbackId = feedback.FeedbackId,
                    Review = feedback.Review,
                    UserId = feedback.UserId,
                    MovieId = feedback.MovieId,
                };
                fcs.Add(f);
                return RedirectToAction("Details", feedback.MovieId);
            }
            return View();
        }
        public ActionResult MovieInfo()
        {
            return View();
        }

    }

}