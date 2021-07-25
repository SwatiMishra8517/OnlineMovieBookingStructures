using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineMovieBooking.Models;
using OnlineMovieBooking.ViewModels;
using OnlineMovieBooking.ControllerService;

namespace OnlineMovieBooking.Controllers
{
    public class UserMovieSelectionController : Controller
    {
        
        private ShowControllerService scs = new ShowControllerService();
        private MovieControllerService mcs = new MovieControllerService();
        // GET: UserMovieSelection
        public ActionResult SelectShowByMovie()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SelectShowByMovie(int movieId)
        {
            List<ShowViewModel> shows = new List<ShowViewModel>();
            List<ShowModel> sms = scs.GetByMovieId(movieId);
            foreach (var show in sms)
            {
                ShowViewModel s = new ShowViewModel
                {
                    ShowId = show.ShowId,
                    Date = show.Date,
                    StartTime = show.StartTime,
                    EndTime = show.EndTime,
                    CinemaHallId = show.CinemaHallId,
                    MovieId = show.MovieId
                };
                shows.Add(s);
            }
            return View(shows);
        }
        public ActionResult SelectShowByCinemaHall()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SelectShowByCinemaHall(int movieId)
        {
            List<ShowViewModel> shows = new List<ShowViewModel>();
            List<ShowModel> sms = scs.GetByMovieId(movieId);
            foreach (var show in sms)
            {
                ShowViewModel s = new ShowViewModel
                {
                    ShowId = show.ShowId,
                    Date = show.Date,
                    StartTime = show.StartTime,
                    EndTime = show.EndTime,
                    CinemaHallId = show.CinemaHallId,
                    MovieId = show.MovieId
                };
                shows.Add(s);
            }
            return View(shows);
        }
    }
}