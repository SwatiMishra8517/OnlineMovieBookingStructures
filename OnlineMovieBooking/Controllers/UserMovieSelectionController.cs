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
        private CityControllerService cs = new CityControllerService();
        private CinemaControllerService cinecs = new CinemaControllerService();
        private ShowControllerService scs = new ShowControllerService();
        private MovieControllerService mcs = new MovieControllerService();
        // GET: UserMovieSelection
        public ActionResult SelectCity()
        {
            List<CityViewModel> cityList = new List<CityViewModel>();
            List<CityModel> cities = cs.GetAll();
            foreach (var city in cities)
            {
                CityViewModel c = new CityViewModel
                {
                    CityId = city.CityId,
                    Name = city.Name,
                    State = city.State,
                    ZipCode = city.ZipCode,
                };
                cityList.Add(c);
            }
            return View(cityList);
        }
        public ActionResult SelectCinemaByCity()
        {
            return View();
        }
        [HttpPost]
            public ActionResult SelectCinemaByCity(int cityId)
        {
            List<CinemaViewModel> cms = new List<CinemaViewModel>();
            List<CinemaModel> cinemas = cinecs.GetByCityId(cityId);
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
        public ActionResult SelectShowByCinema()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SelectShowByCinema(int cinemaId)
        {
            List<ShowViewModel> shows = new List<ShowViewModel>();
            List<ShowModel> sms = scs.GetByCinemaId(cinemaId);
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
    }
}