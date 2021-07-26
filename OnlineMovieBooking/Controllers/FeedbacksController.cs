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
    [Authorize(Users = "admin")]
    public class FeedbacksController : Controller
    {
        private FeedbackControllerService fcs = new FeedbackControllerService();
        private UserControllerService ucs = new UserControllerService();
        private MovieControllerService mcs = new MovieControllerService();

        // GET: Feedbacks
        public ActionResult Index()
        {
            List<FeedbackModel> fml = fcs.GetAll();
            List<FeedbackViewModel> fvl = new List<FeedbackViewModel>();
            foreach(var feedback in fml)
            {
                var user = ucs.GetById(feedback.UserId);
                UserViewModel u = new UserViewModel
                {
                    UserId = user.UserId,
                    Name = user.Name,
                    Username = user.Username,
                    Email = user.Email,
                    MobileNo = user.MobileNo,
                    Password = user.Password
                };
                var movie = mcs.GetById(feedback.MovieId);
                MovieViewModel m = new MovieViewModel
                {
                    MovieId = movie.MovieId,
                    Name = movie.Name,
                    Description = movie.Description,
                    Duration = movie.Duration,
                    ReleaseDate = movie.ReleaseDate,
                    Genre = movie.Genre,
                    Language = movie.Language,
                };
                var f = new FeedbackViewModel
                {
                    FeedbackId = feedback.FeedbackId,
                    Review = feedback.Review,
                    UserId = feedback.UserId,
                    MovieId = feedback.MovieId,
                    Movie = m,
                    User = u,
                };
                fvl.Add(f);
            }
            return View(fvl);
        }

        // GET: Feedbacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModel feedback = fcs.GetById(id: (int)id);
            var user = ucs.GetById(feedback.UserId);
            UserViewModel u = new UserViewModel
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                MobileNo = user.MobileNo,
                Password = user.Password
            };
            var movie = mcs.GetById(feedback.MovieId);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Description = movie.Description,
                Duration = movie.Duration,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Language = movie.Language,
            };
            FeedbackViewModel f =new FeedbackViewModel()
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
                Movie = m,
                User = u,
            };
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // GET: Feedbacks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FeedbackModel feedback = fcs.GetById((int)id);
            var user = ucs.GetById(feedback.UserId);
            UserViewModel u = new UserViewModel
            {
                UserId = user.UserId,
                Name = user.Name,
                Username = user.Username,
                Email = user.Email,
                MobileNo = user.MobileNo,
                Password = user.Password
            };
            var movie = mcs.GetById(feedback.MovieId);
            MovieViewModel m = new MovieViewModel
            {
                MovieId = movie.MovieId,
                Name = movie.Name,
                Description = movie.Description,
                Duration = movie.Duration,
                ReleaseDate = movie.ReleaseDate,
                Genre = movie.Genre,
                Language = movie.Language,
            };
            var f = new FeedbackViewModel()
            {
                FeedbackId = feedback.FeedbackId,
                Review = feedback.Review,
                UserId = feedback.UserId,
                MovieId = feedback.MovieId,
                Movie = m,
                User = u,
            };
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fcs.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
