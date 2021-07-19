using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public class CityRepository : ICityRepository
    {
        private MovieContext db;
        public CityRepository()
        {
            db = new MovieContext();
        }
        public CityRepository(MovieContext context)
        {
            this.db = context;
        }
        public void Add(City city)
        {
            db.Cities.Add(city);
            db.SaveChanges();
        }
        public City GetById(int id)
        {
            return db.Cities.Find(id);
        }
        public void Update(City city)
        {
            var s = GetById(city.CityId);
            s = city;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var city = GetById(id);
            db.Cities.Remove(city);
            db.SaveChanges();
        }
        public List<City> GetAll()
        {
            return db.Cities.ToList();
        }
    }
}
