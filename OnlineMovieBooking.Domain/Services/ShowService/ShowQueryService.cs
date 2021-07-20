using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowService
{
    public class ShowQueryService : IShowQueryService
    {
        private readonly IShowRepository repository;
        private ShowRepository sr;

        public ShowQueryService() { }
        public ShowQueryService(IShowRepository repository)
        {
            this.repository = repository;
        }

        public Show Get(int id)
        {
            Repository.Entities.Show show = sr.GetById(id);
            Show s = new Show
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                MovieId = show.MovieId,
                CinemaHallId = show.CinemaHallId
            };
            return s;
        }

        public List<Show> GetAll()
        {
            var retList = sr.GetAll()
            .Select(show => new Show()
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                MovieId = show.MovieId,
                CinemaHallId = show.CinemaHallId
            }).ToList();
            return retList;
        }
    }
}
