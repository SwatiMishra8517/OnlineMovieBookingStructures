using OnlineMovieBooking.Domain.Services.BookingService;
using OnlineMovieBooking.Models;
using OnlineMovieBooking.Domain.Services.UserServices.BookingService;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMovieBooking.Proxy
{
    public class BookingProxy : IBookingProxy
    {
        private readonly BookingCommandService bcs = new BookingCommandService();
        private readonly BookingQueryService bqs = new BookingQueryService();
        private readonly OnlineMovieBooking.Domain.Services.UserServices.BookingService.BookingQueryService.BookingQueryService ubs = new Domain.Services.UserServices.BookingService.BookingQueryService.BookingQueryService();
        public BookingProxy() { }
        public BookingProxy(BookingQueryService bookingQueryService, BookingCommandService bookingCommandService, OnlineMovieBooking.Domain.Services.UserServices.BookingService.BookingQueryService.BookingQueryService ub)
        {
            this.bcs = bookingCommandService;
            this.bqs = bookingQueryService;
            this.ubs = ub;
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

        public List<BookingModel> GetByShowId(int id)
        {
            List<BookingModel> book = new List<BookingModel>();
            List<OnlineMovieBooking.Domain.DTO.Booking> bl = ubs.GetByShowId(id);
            foreach (var booking in bl)
            {
                BookingModel b = new BookingModel();
                b.BookingId = booking.BookingId;
                b.NumberOfSeats = booking.NumberOfSeats;
                b.Time = booking.Time;
                b.Status = booking.Status;
                b.UserId = booking.UserId;
                b.ShowId = booking.ShowId;
                book.Add(b);
            }
            return book;
        }

        public List<BookingModel> GetByUserId(int id)
        {
            List<BookingModel> book = new List<BookingModel>();
            List<OnlineMovieBooking.Domain.DTO.Booking> bl = ubs.GetByUserId(id);
            foreach (var booking in bl)
            {
                BookingModel b = new BookingModel();
                b.BookingId = booking.BookingId;
                b.NumberOfSeats = booking.NumberOfSeats;
                b.Time = booking.Time;
                b.Status = booking.Status;
                b.UserId = booking.UserId;
                b.ShowId = booking.ShowId;
                book.Add(b);
            }
            return book;
        }

        public int GetNumberOfSeats(int id)
        {
            return ubs.GetNumberOfSeats(id);
        }

        public string GetStatus(int id)
        {
            return ubs.GetStatus(id);
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