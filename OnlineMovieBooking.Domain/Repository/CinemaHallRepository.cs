using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;

namespace OnlineMovieBooking.Domain.Repository
{
    public class CinemaHallRepository : ICinemaHallRepository
    {
        private MovieContext db;
        public CinemaHallRepository() { }
        public CinemaHallRepository(MovieContext movieContext)
        {
            this.db = movieContext;
        }
        public void AddCinemaHall(CinemaHall cinemaHall)
        {
            db = new MovieContext();
            db.CinemaHalls.Add(cinemaHall);
            db.SaveChanges();
        }

        public void DeleteCinemaHall(int id)
        {
            db = new MovieContext();
            var cinema = GetCinemaHallById(id);
            db.CinemaHalls.Remove(cinema);
            db.SaveChanges();
        }

        public void EditCinemaHall(int id, CinemaHall cinemaHall)
        {
            db = new MovieContext();
            var cineHall = GetCinemaHallById(id);
            cineHall = cinemaHall;
            db.SaveChanges();
        }

        public List<CinemaHall> GetAllCinemaHalls()
        {
            db = new MovieContext();
            return db.CinemaHalls.ToList();
        }

        public CinemaHall GetCinemaHallById(int id)
        {
            db = new MovieContext();
            var cinemaHall = db.CinemaHalls.Find(id);
            if(cinemaHall!=null)
            {
                return cinemaHall;
            }
            return null;
        }
    }
}
