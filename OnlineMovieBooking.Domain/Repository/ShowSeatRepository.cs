using OnlineMovieBooking.Domain.Repository.Configuration;
using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Repository
{
    public class ShowSeatRepository : IShowSeatRepository
    {
        private MovieContext db;
        public ShowSeatRepository()
        {
            db = new MovieContext();
        }
        public ShowSeatRepository(MovieContext context)
        {
            this.db = context;
        }
        public void Add(ShowSeat showSeat)
        {
            db.ShowSeats.Add(showSeat);
            db.SaveChanges();
        }
        public ShowSeat GetById(int id)
        {
            return db.ShowSeats.Find(id);
        }
        public void Update(int id, ShowSeat showSeat)
        {
            var s = GetById(id);
            s = showSeat;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var showSeat = GetById(id);
            db.ShowSeats.Remove(showSeat);
            db.SaveChanges();
        }


        public List<ShowSeat> GetByShowId(int id)
        {
            return db.ShowSeats.Where(m => m.ShowId == id).ToList();

        }


        public string GetStatus(int id)
        {
            ShowSeat ss = GetById(id);
            return ss.Status;
        }

        public List<ShowSeat> GetAll()
        {
            return db.ShowSeats.ToList();
        }
        public List<ShowSeat> GetNonReserved()
        {
            return db.ShowSeats.Where(m => m.Status != "R").ToList();
        }
    }
}
