using OnlineMovieBooking.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieBooking.Domain.Services.BookingService
{
    public interface IBookingQueryService
    {
        Booking Get(int id);
        List<Booking> GetAll();
    }
}