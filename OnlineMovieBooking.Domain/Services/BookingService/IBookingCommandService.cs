using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.BookingService
{
    public interface IBookingCommandService
    {
        void Add(Booking booking);
        void Delete(int id);
        void Update(int id, Booking booking);
    }
}