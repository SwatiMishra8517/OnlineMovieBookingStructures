using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;

namespace OnlineMovieBooking.Domain.Repository
{
    public class CinemaRepository : ICinemaRepository
    {
        private MovieContext db = new MovieContext();
        public CinemaRepository()
        {
            db = new MovieContext();
        }
        public CinemaRepository(MovieContext context)
        {
            this.db = context;
        }
        public bool Add(Cinema cinema)
        {
            db.Cinemas.Add(cinema);
            db.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            var cinema = db.Cinemas.Find(id);
            db.Cinemas.Remove(cinema);
            db.SaveChanges();
        }

        public void Update(int id, Cinema cinema)
        {
            var cine = GetById(id);
            cine = cinema;
            db.SaveChanges();
        }

        public List<Cinema> GetAll()
        {
            return db.Cinemas.ToList();
        }

        public Cinema GetById(int id)
        {
            var cinema = db.Cinemas.Find(id);
            return cinema;
        }

        public List<Cinema> GetByCityId(int cityId)
        {
            List<Cinema> cinemas = new List<Cinema>();
            cinemas = db.Cinemas.Where(m => m.CityId == cityId).ToList();
            return cinemas;
        }

        public Cinema GetByName(string name)
        {
            return (Cinema)db.Cinemas.Where(m => m.Name == name);
        }
    }
}
