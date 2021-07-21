using OnlineMovieBooking.Domain.Services.BookingService;
using OnlineMovieBooking.Domain.Services.UserServices.BookingService.BookingQueryService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public interface IBookingProxy
    {
        void Add(BookingModel booking);
        void Delete(int id);
        void Update(int id, BookingModel booking);
        BookingModel GetById(int id);
        List<BookingModel> GetAll();
        int GetNumberOfSeats(int id);
        string GetStatus(int id);
        List<BookingModel> GetByUserId(int id);
        List<BookingModel> GetByShowId(int id);
    }
}