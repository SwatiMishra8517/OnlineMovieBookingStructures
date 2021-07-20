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
        public ShowProxy() { }
        public ShowProxy(ShowQueryService showQueryService, ShowCommandService showCommandService)
        {
            this.scs = showCommandService;
            this.sqs = showQueryService;
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