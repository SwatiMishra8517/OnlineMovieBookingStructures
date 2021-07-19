using OnlineMovieBooking.Domain.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.Repository.Configuration;

namespace OnlineMovieBooking.Domain.Repository

{
    public class BookingRepository : IBookingRepository
    {
        private MovieContext db;
        
        public BookingRepository() { }
        public BookingRepository(MovieContext movieContext)
        {
            this.db = movieContext;
        }
        public bool Add(Booking booking)
        {
            db = new MovieContext();
            db.Bookings.Add(booking);
            db.SaveChanges();
            return true;
        }

        public void Delete(int id)
        {
            db = new MovieContext();
            var booking = db.Bookings.Find(id);
            if(booking!=null)
            {
                db.Bookings.Remove(booking);
                db.SaveChanges();
            }
        }

        public void Edit(int id,Booking booking)
        {
            db = new MovieContext();
            var book = GetById(id);
            book = booking;
            db.SaveChanges();
        }

        public List<Booking> GetAll()
        {
            db = new MovieContext();
            return db.Bookings.ToList();
        }

        public Booking GetById(int id)
        {
            db = new MovieContext();
            var booking = db.Bookings.Find(id);
            if(booking!=null)
            {
                return booking;
            }
            return null;
        }
    }
}
