using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;

namespace OnlineMovieBooking.Domain.Repository
{
    public class CinemaSeatRepository : ICinemaSeatRepository
    {
        private MovieContext db = new MovieContext();
        public bool Add(CinemaSeat cinemaSeat)
        {
            db.CinemaSeats.Add(cinemaSeat);
            db.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            var cine = GetById(id);
            db.CinemaSeats.Remove(cine);
            db.SaveChanges();
        }

        public void Update(int id, CinemaSeat cinemaSeat)
        {
            var cine = GetById(id);
            cine = cinemaSeat;
            db.SaveChanges();
        }

        public List<CinemaSeat> GetAll()
        {
            return db.CinemaSeats.ToList();
        }

        public CinemaSeat GetById(int id)
        {
            return db.CinemaSeats.Find(id);
        }
    }
}
