using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.BookingService.BookingQueryService
{
    class BookingQueryService : IBookingQueryService
    {
        BookingRepository br = new BookingRepository();
        public Booking GetById(int id)
        {
            DTO.Booking b = new Booking();
            Repository.Entities.Booking booking = br.GetById(id);
            b.BookingId = booking.BookingId;
            b.NumberOfSeats= booking.NumberOfSeats;
            b.Time= booking.Time;
            b.Status= booking.Status;
            b.UserId= booking.UserId;
            b.ShowId= booking.ShowId;
            b.Payments = (ICollection<Payment>)booking.Payments;
            b.ShowSeats= (ICollection<ShowSeat>)booking.ShowSeats;
            return b;
        }

        public List<Booking> GetByShowId(int id)
        {
            List<DTO.Booking> book = new List<Booking>();
            List<Repository.Entities.Booking> bl = br.GetByShowId(id);
            foreach(var booking in bl)
            {
                DTO.Booking b = new Booking();
                b.BookingId = booking.BookingId;
                b.NumberOfSeats = booking.NumberOfSeats;
                b.Time = booking.Time;
                b.Status = booking.Status;
                b.UserId = booking.UserId;
                b.ShowId = booking.ShowId;
                b.Payments = (ICollection<Payment>)booking.Payments;
                b.ShowSeats = (ICollection<ShowSeat>)booking.ShowSeats;
                book.Add(b);
            }
            return book;
        }

        public List<Booking> GetByUserId(int id)
        {
            List<DTO.Booking> book = new List<Booking>();
            List<Repository.Entities.Booking> bl = br.GetByUserId(id);
            foreach (var booking in bl)
            {
                DTO.Booking b = new Booking();
                b.BookingId = booking.BookingId;
                b.NumberOfSeats = booking.NumberOfSeats;
                b.Time = booking.Time;
                b.Status = booking.Status;
                b.UserId = booking.UserId;
                b.ShowId = booking.ShowId;
                b.Payments = (ICollection<Payment>)booking.Payments;
                b.ShowSeats = (ICollection<ShowSeat>)booking.ShowSeats;
                book.Add(b);
            }
            return book;
        }

        public int GetNumberOfSeats(int id)
        {
            return br.GetNumberOfSeats(id);

        }

        public string GetStatus(int id)
        {
            return br.GetStatus(id);
        }
    }
}
