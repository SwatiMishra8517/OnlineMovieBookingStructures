using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.BookingService
{
    public class BookingQueryService : IBookingQueryService
    {
        private readonly IBookingRepository repository;
        private BookingRepository br;
        public BookingQueryService(){}
        public BookingQueryService(IBookingRepository repository)
        {
            this.repository = repository;
        }
        public Booking Get(int id)
        {
            Repository.Entities.Booking booking = br.GetById(id);
            Booking b = new Booking
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                UserId = booking.UserId,
                ShowId = booking.ShowId
            };
            return b;
        }

        public List<Booking> GetAll()
        {
            var retList = br.GetAll()
            .Select(booking => new Booking()
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                UserId = booking.UserId,
                ShowId = booking.ShowId
            })
            .ToList();
            return retList;
        }
    }
}
