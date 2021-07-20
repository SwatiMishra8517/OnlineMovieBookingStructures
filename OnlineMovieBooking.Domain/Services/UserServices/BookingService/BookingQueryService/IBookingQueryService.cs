using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMovieBooking.Domain.DTO;
using OnlineMovieBooking.Domain.Repository;

namespace OnlineMovieBooking.Domain.Services.UserServices.BookingService.BookingQueryService
{
    interface IBookingQueryService
    {
        Booking GetById(int id);
        int GetNumberOfSeats(int id);
        string GetStatus(int id);
        List<Booking> GetByUserId(int id);
        List<Booking> GetByShowId(int id);
    }
}
