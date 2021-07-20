using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.BookingService
{
    public class BookingCommandService : IBookingCommandService
    {
        private readonly IBookingRepository repository;
        private BookingRepository br;
        public BookingCommandService() { }
        public BookingCommandService(IBookingRepository repository)
        {
            this.repository = repository;
        }
        public void Add(Booking booking)
        {
            Repository.Entities.Booking b = new Repository.Entities.Booking
            {
                BookingId = booking.BookingId,
                NumberOfSeats = booking.NumberOfSeats,
                Time = booking.Time,
                Status = booking.Status,
                UserId = booking.UserId,
                ShowId = booking.ShowId
            };
            br.Add(b);
        }

        public void Delete(int id)
        {
            Repository.Entities.User u = new Repository.Entities.User();
            br.Delete(id);
        }

        public void Update(int id, Booking booking)
        {
            Repository.Entities.Booking b = br.GetById(id);
            b.BookingId = booking.BookingId;
            b.NumberOfSeats = booking.NumberOfSeats;
            b.Time = booking.Time;
            b.Status = booking.Status;
            b.UserId = booking.UserId;
            b.ShowId = booking.ShowId;
            br.Update(id, b);
        }
    }
}
