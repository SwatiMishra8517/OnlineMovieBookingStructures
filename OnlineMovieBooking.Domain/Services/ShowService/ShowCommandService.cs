using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.ShowService
{
    public class ShowCommandService : IShowCommandService
    {
        private readonly IShowRepository repository;
        private ShowRepository sr;
        public ShowCommandService() { }
        
        public ShowCommandService(IShowRepository repository)
        {
            this.repository = repository;
        }
        public void Add(Show show)
        {
            sr = new ShowRepository();
            Repository.Entities.Show s = new Repository.Entities.Show
            {
                ShowId = show.ShowId,
                Date = show.Date,
                StartTime = show.StartTime,
                EndTime = show.EndTime,
                MovieId = show.MovieId,
                CinemaHallId = show.CinemaHallId
            };
            sr.Add(s);
        }

        public void Delete(int id)
        {
            sr = new ShowRepository();
            Repository.Entities.Show s = new Repository.Entities.Show();
            sr.Delete(id);
        }

        public void Update(int id, Show show)
        {
            sr = new ShowRepository();
            Repository.Entities.Show s = sr.GetById(id);
            s.ShowId = show.ShowId;
            s.Date = show.Date;
            s.StartTime = show.StartTime;
            s.EndTime = show.EndTime;
            s.MovieId = show.MovieId;
            s.CinemaHallId = show.CinemaHallId;
            sr.Update(id, s);
        }
    }
}
