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
        public CinemaHallRepository() 
        {
            db = new MovieContext();
        }
        public CinemaHallRepository(MovieContext movieContext)
        {
            this.db = movieContext;
        }
        public void Add(CinemaHall cinemaHall)
        {
            db.CinemaHalls.Add(cinemaHall);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var cinema = GetById(id);
            db.CinemaHalls.Remove(cinema);
            db.SaveChanges();
        }

        public void Update(int id, CinemaHall cinemaHall)
        {
            var cineHall = GetById(id);
            cineHall = cinemaHall;
            db.SaveChanges();
        }

        public List<CinemaHall> GetAll()
        {
            return db.CinemaHalls.ToList();
        }

        public CinemaHall GetById(int id)
        {
            return db.CinemaHalls.Find(id);
        }

        public List<CinemaHall> GetByCinemaId(int id)
        {
            List<CinemaHall> cinemaHalls = db.CinemaHalls.Where(m => m.CinemaId == id).ToList();
            return cinemaHalls;
        }

        public CinemaHall GetByName(string name)
        {
            return (CinemaHall)db.CinemaHalls.Where(m => m.Name == name);
        }
    }
}
