using OnlineMovieBooking.Domain.Services.BookingService;
using OnlineMovieBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class BookingProxy : IBookingProxy
    {
        private readonly BookingCommandService bcs = new BookingCommandService();
        private readonly BookingQueryService bqs = new BookingQueryService();
        public BookingProxy() { }
        public BookingProxy(BookingQueryService bookingQueryService, BookingCommandService bookingCommandService)
        {
            this.bcs = bookingCommandService;
            this.bqs = bookingQueryService;
        }

        public void Add(BookingModel booking)
        {
            var b = new OnlineMovieBooking.Domain.DTO.Booking
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                ShowId = booking.ShowId,
                UserId = booking.UserId,
            };
            bcs.Add(b);
        }

        public void Delete(int id)
        {
            bcs.Delete(id);
        }

        public List<BookingModel> GetAll()
        {
            List<OnlineMovieBooking.Domain.DTO.Booking> bookings = bqs.GetAll();
            List<BookingModel> bms = new List<BookingModel>();
            foreach (var booking in bookings)
            {
                BookingModel b = new BookingModel
                {
                    BookingId = booking.BookingId,
                    NumberOfSeats = booking.NumberOfSeats,
                    Time = booking.Time,
                    Status = booking.Status,
                    ShowId = booking.ShowId,
                    UserId = booking.UserId,
                };
                bms.Add(b);
            }
            return bms;
        }

        public BookingModel GetById(int id)
        {
            var booking = bqs.Get(id);
            BookingModel b = new BookingModel
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                ShowId = booking.ShowId,
                UserId = booking.UserId,
            };
            return b;
        }

        public void Update(int id, BookingModel booking)
        {
            var b = new OnlineMovieBooking.Domain.DTO.Booking
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                ShowId = booking.ShowId,
                UserId = booking.UserId,
            };
            bcs.Update(id, b);

        }
    }
}