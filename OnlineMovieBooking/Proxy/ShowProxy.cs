using OnlineMovieBooking.Domain.Services.ShowService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class ShowProxy : IShowProxy
    {
        private readonly ShowCommandService scs = new ShowCommandService();
        private readonly ShowQueryService sqs = new ShowQueryService();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.ShowService.ShowQueryService.ShowQueryService uss = new Domain.Services.UserServices.ShowService.ShowQueryService.ShowQueryService();
        public ShowProxy() { }
        public ShowProxy(ShowQueryService showQueryService, ShowCommandService showCommandService, OnlineMovieBooking.Domain.Services.UserServices.ShowService.ShowQueryService.ShowQueryService us)
        {
            this.scs = showCommandService;
            this.sqs = showQueryService;
            this.uss = us;
        }

        public void Add(ShowModel show)
        {
            var u = new OnlineMovieBooking.Domain.DTO.Show
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                CinemaHallId = show.CinemaHallId,
                MovieId = show.MovieId,
            };
            scs.Add(u);
        }

        public void Delete(int id)
        {
            scs.Delete(id);
        }

        public List<ShowModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.Show> shows = sqs.GetAll();
            List<ShowModel> sms = new List<ShowModel>();
            foreach (var show in shows)
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
                sms.Add(s);
            }
            return sms;
        }

        public List<ShowModel> GetByCinemaHallId(int id)
        {
            List<ShowModel> s = new List<ShowModel>();
            List<OnlineMovieBooking.Domain.DTO.Show> sl = uss.GetByCinemaHallId(id);
            foreach (var show in sl)
            {
                ShowModel sh = new ShowModel();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                s.Add(sh);

            }
            return s;
        }

        public List<ShowModel> GetByCinemaId(int id)
        {
            List<ShowModel> s = new List<ShowModel>();
            List<OnlineMovieBooking.Domain.DTO.Show> sl = uss.GetByCinemaId(id);
            foreach (var show in sl)
            {
                ShowModel sh = new ShowModel();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                s.Add(sh);

            }
            return s;
        }

        public List<ShowModel> GetByDate(DateTime date)
        {
            List<ShowModel> s = new List<ShowModel>();
            List<OnlineMovieBooking.Domain.DTO.Show> sl = uss.GetByDate(date);
            foreach (var show in sl)
            {
                ShowModel sh = new ShowModel();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                s.Add(sh);

            }
            return s;
        }

        public ShowModel GetById(int id)
        {
            var show = sqs.Get(id);
            ShowModel u = new ShowModel
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                CinemaHallId = show.CinemaHallId,
                MovieId = show.MovieId
            };
            return u;
        }

        public List<ShowModel> GetByMovieId(int id)
        {
            List<ShowModel> s = new List<ShowModel>();
            List<OnlineMovieBooking.Domain.DTO.Show> sl = uss.GetByMovieId(id);
            foreach (var show in sl)
            {
                ShowModel sh = new ShowModel();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                s.Add(sh);

            }
            return s;
        }

        public List<ShowModel> GetByStartTime(DateTime time)
        {
            List<ShowModel> s = new List<ShowModel>();
            List<OnlineMovieBooking.Domain.DTO.Show> sl = uss.GetByStartTime(time);
            foreach (var show in sl)
            {
                ShowModel sh = new ShowModel();
                sh.ShowId = show.ShowId;
                sh.Date = show.Date;
                sh.StartTime = show.StartTime;
                sh.EndTime = show.EndTime;
                sh.CinemaHallId = show.CinemaHallId;
                sh.MovieId = show.MovieId;
                s.Add(sh);

            }
            return s;
        }

        public void Update(int id, ShowModel show)
        {
            var s = new OnlineMovieBooking.Domain.DTO.Show
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                CinemaHallId = show.CinemaHallId,
                MovieId = show.MovieId
            };
            scs.Update(id, s);

        }
    }
}