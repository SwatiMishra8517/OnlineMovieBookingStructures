using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineMovieBooking.Proxy;
using OnlineMovieBooking.Models;

namespace OnlineMovieBooking.ControllerService
{
    public class BookingControllerService
    {
        private BookingProxy bookingProxy = new BookingProxy();
        public void Add(BookingModel booking)
        {
            bookingProxy.Add(booking);
        }
        public void Delete(int id)
        {
            bookingProxy.Delete(id);
        }
        public void Update(int id, BookingModel booking)
        {
            bookingProxy.Update(id, booking);
        }
        public BookingModel GetById(int id)
        {
            return bookingProxy.GetById(id);
        }
        public List<BookingModel> GetAll()
        {
            return bookingProxy.GetAll();
        }
        public int GetNumberOfSeats(int id)
        {
            return bookingProxy.GetNumberOfSeats(id);
        }
        public string GetStatus(int id)
        {
            return bookingProxy.GetStatus(id);
        }
        public List<BookingModel> GetByUserId(int id)
        {
            return bookingProxy.GetByUserId(id);
        }
        public List<BookingModel> GetByShowId(int id)
        {
            return bookingProxy.GetByShowId(id);
        }
    }
}