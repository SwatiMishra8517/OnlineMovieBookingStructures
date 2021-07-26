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
        private ShowSeatControllerService sss = new ShowSeatControllerService();
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
        public ActionResult SelectShowByMovie(int id)
        {
            List<ShowViewModel> shows = new List<ShowViewModel>();
            List<ShowModel> sms = scs.GetByMovieId(id);
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
        public ActionResult SelectSeatByShow(int id)
        {
            List<ShowSeatModel> showSeats = sss.GetAll();
            List<ShowSeatViewModel> ums = new List<ShowSeatViewModel>();


            foreach (var showSeat in showSeats)
            {
                ShowSeatViewModel ss = new ShowSeatViewModel();
                ss.ShowId =showSeat.ShowId;
                ss.ShowSeatId = showSeat.ShowSeatId;
                if(showSeat.Status=="R")
                {
                    ss.Status = true;
                }
                else
                {
                    ss.Status = false;
                }
                
                ums.Add(ss);
            }

           
            return View(ums);
        }
        public ActionResult GetNonReserved()
        {
            List<ShowSeatModel> showSeats = sss.GetAll();
            List<ShowSeatViewModel> ums = new List<ShowSeatViewModel>();


            foreach (var showSeat in showSeats)
            {
                ShowSeatViewModel ss = new ShowSeatViewModel();
                ss.ShowId = showSeat.ShowId;
                ss.ShowSeatId = showSeat.ShowSeatId;
                if (showSeat.Status != "R")
                {
                    ss.Status = false;
                    ums.Add(ss);
                }  
            }


            return View(ums);
        }
        public ActionResult SelectSeat(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit( ShowSeatViewModel showSeat)
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
                sss.Update(showSeat.ShowSeatId, s);
                return RedirectToAction("Index");
            }
            ViewBag.ShowId = new SelectList(scs.GetAll(), "ShowId", "ShowId", showSeat.ShowId);
            return View(showSeat);
        }



    }
}