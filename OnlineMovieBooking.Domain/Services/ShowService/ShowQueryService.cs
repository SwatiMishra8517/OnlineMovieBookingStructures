using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using OnlineMovieBooking.Domain.Services.CinemaHallService;
using OnlineMovieBooking.Domain.Services.MovieService;
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
        private CinemaHallQueryService chqs = new CinemaHallQueryService();
        private MovieQueryService mqs = new MovieQueryService();

        public ShowQueryService() { }
        public ShowQueryService(IShowRepository repository)
        {
            this.repository = repository;
        }

        public Show Get(int id)
        {
            sr = new ShowRepository();
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
            sr = new ShowRepository();
            var retList = sr.GetAll()
            .Select(show => new Show()
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                MovieId = show.MovieId,
                CinemaHallId = show.CinemaHallId,
                CinemaHall = chqs.Get(show.CinemaHallId),
                Movie = mqs.Get(show.MovieId)
            }).ToList();
            return retList;
        }
    }
}
