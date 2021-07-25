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
        private CinemaHallControllerService ccs = new CinemaHallControllerService();
        // GET: UserMovieSelection

        public ActionResult CinemaHall()
        {
            var cinemas = ccs.GetAll();
            List<CinemaHallViewModel> cList = new List<CinemaHallViewModel>();
            foreach (var cinema in cinemas)
            {
                CinemaHallViewModel c = new CinemaHallViewModel
                {
                    CinemaHallId = cinema.CinemaHallId,
                    Name = cinema.Name
                };
                cList.Add(c);
            }
            return View(cList);
        }

        public ActionResult SelectShowByCinemaHall(int id)
        {
            List<ShowViewModel> shows = new List<ShowViewModel>();
            List<ShowModel> sms = scs.GetByCinemaHallId(id);
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